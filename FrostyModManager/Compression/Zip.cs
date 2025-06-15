using FrostySdk.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace FrostyModManager.Compression
{
    public class ZipDecompressor : IDecompressor
    {
        private ZipArchive archive;
        private string archiveName;

        public bool OpenArchive(string filename)
        {
            archive = new ZipArchive(new FileStream(filename, FileMode.Open, FileAccess.Read), ZipArchiveMode.Read);
            archiveName = filename;
            return true;
        }

        public void CloseArchive()
        {
            archive.Dispose();
            archive = null;
        }

        public IEnumerable<CompressedFileInfo> EnumerateFiles()
        {
            return archive.Entries.Select(e => new CompressedFileInfo(e.FullName, (ulong)e.CompressedLength, (ulong)e.Length, e.Open()));
        }

        public void DecompressToFile(CompressedFileInfo fileInfo, string filename)
        {
            byte[] buffer = DecompressToMemory(fileInfo);
            using (NativeWriter writer = new NativeWriter(new FileStream(filename, FileMode.Create)))
                writer.Write(buffer);
        }

        public byte[] DecompressToMemory(CompressedFileInfo fileInfo)
        {
            var currentEntry = GetEntryByName(fileInfo.Filename);

            if (currentEntry == null)
            {
                throw new ArgumentException($"Compressed zip file '{fileInfo.Filename}' could not be found in archive file '{archiveName}'.");
            }

            Stream stream = currentEntry.Open();
            using (MemoryStream ms = new MemoryStream())
            {
                long remainingLength = currentEntry.Length;
                while (remainingLength > 0)
                {
                    int bufferLength = (remainingLength > int.MaxValue) ? int.MaxValue : (int)remainingLength;
                    byte[] tmpBuffer = new byte[bufferLength];

                    stream.Read(tmpBuffer, 0, bufferLength);
                    ms.Write(tmpBuffer, 0, bufferLength);

                    remainingLength -= bufferLength;
                }

                return ms.ToArray();
            }
        }

        private ZipArchiveEntry GetEntryByName(string name)
        {
            return archive.Entries.FirstOrDefault(e =>
            {
                var fileInfo = new CompressedFileInfo(e.FullName, (ulong)e.CompressedLength, (ulong)e.Length, e.Open());

                return fileInfo.Filename == name;
            });
        }
    }

    public class ZipCompressor
    {
        ZipArchive archive;
        string name;

        public bool CreateArchive(string filename)
        {
            archive = ZipFile.Open(filename, ZipArchiveMode.Create);
            name = filename;
            return true;
        }

        public void AddEntry(string fileName)
        {
            archive.CreateEntryFromFile(name, fileName);
        }
    }
}
