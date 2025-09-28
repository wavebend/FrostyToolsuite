using System;
using System.Collections.Generic;
using System.IO;
using SharpSevenZip;
using System.Linq;

namespace FrostyModManager.Compression
{
    public class SharpSevenZipDecompressor : IDecompressor
    {
        private string archiveName;

        public bool OpenArchive(string filename)
        {
            archiveName = filename;

            if (!File.Exists(archiveName))
            {
                return false;
            }

            using (var executor = new SharpSevenZipExtractor(archiveName))
            {
                return executor.Check();
            }
        }

        public void DecompressToFile(CompressedFileInfo fileInfo, string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = DecompressToMemory(fileInfo);
                fs.Write(buffer, 0, buffer.Length);
            }
        }

        public byte[] DecompressToMemory(CompressedFileInfo fileInfo)
        {
            using (var ms = new MemoryStream())
            using (var executor = new SharpSevenZipExtractor(archiveName))
            {
                var fileData = executor.ArchiveFileData.FirstOrDefault(x => {
                    var fi = new CompressedFileInfo(x.FileName, x.Size, x.Size);

                    return fi.Filename == fileInfo.Filename;
                });

                if (fileData == null)
                {
                    string ext = Path.GetExtension(archiveName).Replace(".", "");
                    throw new ArgumentException($"Compressed {ext} file '{fileInfo.Filename}' could not be found in archive file '{archiveName}'.");
                }

                executor.ExtractFile(fileData.FileName, ms);

                return ms.ToArray();
            }
        }

        public IEnumerable<CompressedFileInfo> EnumerateFiles()
        {
            using (var executor = new SharpSevenZipExtractor(archiveName))
            {
                return executor.ArchiveFileData.Where(x => !x.IsDirectory).Select(x => new CompressedFileInfo(x.FileName, x.Size, x.Size));
            }
        }
    }
}
