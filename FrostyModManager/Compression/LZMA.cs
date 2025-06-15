using System;
using System.Collections.Generic;
using System.IO;
using FrostySdk.IO;
using System.Collections;
using System.Runtime.InteropServices;
using SharpSevenZip;
using System.Linq;

namespace FrostyModManager.Compression
{
    public class SevenZipDecompressor : IDecompressor
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

        public void CloseArchive()
        {

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
                    throw new ArgumentException($"Compressed 7z file '{fileInfo.Filename}' could not be found in archive file '{archiveName}'.");
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
