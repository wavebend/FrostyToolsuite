using Frosty.Controls;
using Frosty.Core;
using Frosty.Core.Windows;
using FrostySdk.IO;
using FrostySdk.Managers;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FrostySdk.Managers.Entries;
using EbxToXmlPlugin.Windows;
using FrostySdk;
using System.Windows;

namespace EbxToXmlPlugin
{
    public class EbxToXmlMenuExtension : MenuExtension
    {
        internal static ImageSource imageSource =
            new ImageSourceConverter().ConvertFromString(
                "pack://application:,,,/EbxToXmlPlugin;component/Images/EbxToXml.png") as ImageSource;

        public override string TopLevelMenuName => "Tools";
        public override string SubLevelMenuName => null;
        public override string MenuItemName => "Export EBX to XML";
        public override ImageSource Icon => imageSource;

        private readonly object progressLock = new object();
        private readonly object logLock = new object();

        private class FileData
        {
            public string FilePath { get; set; }
            public MemoryStream DataStream { get; set; }
        }

        public override RelayCommand MenuItemClicked => new RelayCommand((o) =>
        {
            EbxToXmlWindow win = new EbxToXmlWindow();
            if (win.ShowDialog() == false)
                return;

            bool isGameOnSSD = FrostyMessageBox.Show("Is the game installed on a SSD?\n\n(Note: By selecting yes, parallelism will be used to speed up the export).", "Frosty", MessageBoxButton.YesNo) == MessageBoxResult.Yes;
            bool exportAsYaml = win.exportAsYamlCheckBox.IsChecked ?? false;
            bool skipConversationsFolder = win.skipConversationsCheckBox.IsChecked ?? false;
            bool skipVirtualFolder = win.skipVirtualCheckBox.IsChecked ?? false;
            int tabSize = Config.Get<int>("ExportTabSize", 2);

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string outDir = fbd.SelectedPath;

                    FrostyTaskWindow.Show("Exporting EBX", "", (task) =>
                    {
                        int parallelismReadCount = isGameOnSSD
                            ? Math.Min(Environment.ProcessorCount - 2, 16)
                            : Math.Min(Environment.ProcessorCount - 2, 2);
                        int parallelismWriteCount = isGameOnSSD // we can't know if we're writing to a ssd, so to be safe.
                            ? 2
                            : 1;
                        uint totalCount = App.AssetManager.GetEbxCount();
                        int processedCount = 0;
                        const int updateFrequency = 10;

                        using (BlockingCollection<FileData> fileDataCollection =
                               new BlockingCollection<FileData>(boundedCapacity: 20))
                        {
                            CancellationTokenSource cts = new CancellationTokenSource();
                            CancellationToken token = cts.Token;
                            Task[] writerTasks = new Task[parallelismWriteCount];
                            for (int i = 0; i < writerTasks.Length; i++)
                            {
                                writerTasks[i] = Task.Run(() =>
                                {
                                    foreach (var fileData in fileDataCollection.GetConsumingEnumerable(token))
                                    {
                                        try
                                        {
                                            Directory.CreateDirectory(Path.GetDirectoryName(fileData.FilePath));
                                            using (FileStream fs = new FileStream(fileData.FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                                            {
                                                fileData.DataStream.Position = 0;
                                                fileData.DataStream.CopyTo(fs);
                                            }
                                            fileData.DataStream.Dispose();
                                        }
                                        catch (Exception ex)
                                        {
                                            lock (logLock)
                                            {
                                                App.Logger.Log("Failed to write file {0} | Error: {1}", fileData.FilePath, ex.Message);
                                            }
                                        }

                                        int currentCount = Interlocked.Increment(ref processedCount);
                                        if (currentCount % updateFrequency == 0 || currentCount == totalCount)
                                        {
                                            double percent = (currentCount / (double)totalCount) * 100.0;
                                            lock (progressLock)
                                            {
                                                task.Update($"Wrote {currentCount} of {totalCount} to {outDir}", percent);
                                            }
                                        }
                                    }
                                }, token);
                            }

                            try
                            {
                                ParallelOptions parallelOptions = new ParallelOptions
                                {
                                    MaxDegreeOfParallelism = parallelismReadCount
                                };

                                Parallel.ForEach(App.AssetManager.EnumerateEbx(), parallelOptions, (entry) =>
                                {
                                    if (!ShouldProcess(entry, skipConversationsFolder, skipVirtualFolder))
                                    {
                                        int currentCount = Interlocked.Increment(ref processedCount);
                                        if (currentCount % updateFrequency == 0 || currentCount == totalCount)
                                        {
                                            double percent = (currentCount / (double)totalCount) * 100.0;
                                            lock (progressLock)
                                            {
                                                task.Update($"Wrote {currentCount} of {totalCount} to {outDir}", percent);
                                            }
                                        }
                                        return;
                                    }

                                    string sanitizedFilename = string.Concat(entry.Filename.Split(Path.GetInvalidFileNameChars()));
                                    string extension = exportAsYaml ? ".yaml" : ".xml";
                                    string filename = sanitizedFilename + extension;
                                    string fullPath = Path.Combine(outDir, entry.Path);
                                    string filePath = Path.Combine(fullPath, filename);

                                    if (File.Exists(filePath))
                                    {
                                        int currentCount = Interlocked.Increment(ref processedCount);
                                        if (currentCount % updateFrequency == 0 || currentCount == totalCount)
                                        {
                                            double percent = (currentCount / (double)totalCount) * 100.0;
                                            lock (progressLock)
                                            {
                                                task.Update($"Wrote {currentCount} of {totalCount} to {outDir}", percent);
                                            }
                                        }
                                        return;
                                    }

                                    try
                                    {
                                        EbxAsset asset = App.AssetManager.GetEbx(entry);
                                        MemoryStream ms = new MemoryStream();
                                        if (exportAsYaml)
                                        {
                                            using (EbxYamlWriter writer = new EbxYamlWriter(asset, ms, App.AssetManager, tabSize, InIsDebugInformationEnabled: false, inLeaveStreamOpen: true))
                                            {
                                                writer.WriteObjects();
                                            }
                                        }
                                        else
                                        {
                                            using (EbxXmlWriter writer = new EbxXmlWriter(asset, ms, App.AssetManager, tabSize, InIsDebugInformationEnabled: false, inLeaveStreamOpen: true))
                                            {
                                                writer.WriteObjects();
                                            }
                                        }
                                        fileDataCollection.Add(new FileData
                                        {
                                            FilePath = filePath,
                                            DataStream = ms
                                        }, token);
                                    }
                                    catch (Exception ex)
                                    {
                                        lock (logLock)
                                        {
                                            App.Logger.Log("Failed to export {0} | Error: {1}", entry.Filename, ex.Message);
                                        }
                                    }
                                });
                            }
                            catch (OperationCanceledException)
                            {
                            }
                            finally
                            {
                                fileDataCollection.CompleteAdding();
                            }

                            Task.WaitAll(writerTasks, token);
                        }

                        lock (progressLock)
                        {
                            task.Update("Export Complete", 100.0);
                        }
                    });

                    FrostyMessageBox.Show("Successfully exported EBX to " + outDir, "Frosty Editor");
                }
            }
        });

        private static bool ShouldProcess(EbxAssetEntry entry, bool skipConversations, bool skipVirtual)
        {
            if (skipConversations && entry.Path.StartsWith("conversations", StringComparison.OrdinalIgnoreCase))
                return false;
            if (skipVirtual && entry.Path.StartsWith("virtual", StringComparison.OrdinalIgnoreCase))
                return false;
            return true;
        }
    }
}
