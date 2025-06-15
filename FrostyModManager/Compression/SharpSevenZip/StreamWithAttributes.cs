using System;
using System.IO;

namespace SharpSevenZip
{
    public class StreamWithAttributes
    {
        public StreamWithAttributes(Stream stream, DateTime? creationTime = null, DateTime? lastWriteTime = null, DateTime? lastAccessTime = null)
        {
            Stream = stream;
            CreationTime = creationTime;
            LastWriteTime = lastWriteTime;
            LastAccessTime = lastAccessTime;
        }

        public Stream Stream { get; set; }
        public DateTime? CreationTime { get; set; } = null;
        public DateTime? LastWriteTime { get; set; } = null;
        public DateTime? LastAccessTime { get; set; } = null;
    }
}