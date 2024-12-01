﻿using Frosty.Hash;
using FrostySdk.Interfaces;
using FrostySdk.IO;
using FrostySdk.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FrostySdk.BaseProfile
{
    public class BaseBinarySbWriter : IBinarySbWriter
    {
        public void Write(DbWriter writer, DbObject bundleObj, Endian endian)
        {
            writer.Write(0xDEADBABE, Endian.Big);

            long startPos = writer.Position;

            uint magicSalted = (uint)BaseBinarySb.GetMagic() ^ BaseBinarySb.GetSalt();
            writer.Write(magicSalted, endian);

            int totalCount = bundleObj.GetValue<DbObject>("ebx").Count + bundleObj.GetValue<DbObject>("res").Count + bundleObj.GetValue<DbObject>("chunks").Count;
            writer.Write(totalCount, endian);

            int ebxCount = bundleObj.GetValue<DbObject>("ebx").Count;
            writer.Write(ebxCount, endian);

            int resCount = bundleObj.GetValue<DbObject>("res").Count;
            writer.Write(resCount, endian);

            int chunksCount = bundleObj.GetValue<DbObject>("chunks").Count;
            writer.Write(chunksCount, endian);

            writer.Write(0xDEADBABE, endian);
            writer.Write(0xDEADBABE, endian);
            writer.Write(0xDEADBABE, endian);

            // Writing bundle to stream, bc we might need to compress it
            MemoryStream ms = new MemoryStream();
            using (NativeWriter bundleWriter = new NativeWriter(ms, true))
            {
                if (BaseBinarySb.GetMagic() == BaseBinarySb.Magic.Standard)
                {
                    // sha1's
                    foreach (DbObject ebx in bundleObj.GetValue<DbObject>("ebx"))
                        bundleWriter.Write(ebx.GetValue<Sha1>("sha1"));
                    foreach (DbObject res in bundleObj.GetValue<DbObject>("res"))
                        bundleWriter.Write(res.GetValue<Sha1>("sha1"));
                    foreach (DbObject chunk in bundleObj.GetValue<DbObject>("chunks"))
                        bundleWriter.Write(chunk.GetValue<Sha1>("sha1"));
                }

                // names
                uint nameOffset = 0; 
                Dictionary<string, uint> stringToOffsetMap = new Dictionary<string, uint>(ebxCount + resCount);
                List<string> stringsToPrint = new List<string>();
                foreach (DbObject ebx in bundleObj.GetValue<DbObject>("ebx"))
                {
                    string name = ebx.GetValue<string>("name");
                    if (!stringToOffsetMap.ContainsKey(name))
                    {
                        stringsToPrint.Add(name);
                        stringToOffsetMap.Add(name, nameOffset);
                        nameOffset += (uint)name.Length + 1;
                    }
                    uint offset = stringToOffsetMap[name];
                    uint originalSize = ebx.GetValue<uint>("originalSize");
                    bundleWriter.Write(stringToOffsetMap[name], endian);
                    bundleWriter.Write(originalSize, endian);
                }
                foreach (DbObject res in bundleObj.GetValue<DbObject>("res"))
                {
                    string name = res.GetValue<string>("name");
                    if (!stringToOffsetMap.ContainsKey(name))
                    {
                        stringsToPrint.Add(name);
                        stringToOffsetMap.Add(name, nameOffset);
                        nameOffset += (uint)name.Length + 1;
                    }
                    uint offset = stringToOffsetMap[name];
                    uint originalSize = res.GetValue<uint>("originalSize");
                    bundleWriter.Write(stringToOffsetMap[name], endian);
                    bundleWriter.Write(originalSize, endian);
                }

                // res
                foreach (DbObject res in bundleObj.GetValue<DbObject>("res"))
                    bundleWriter.Write(res.GetValue<uint>("resType"), endian);
                foreach (DbObject res in bundleObj.GetValue<DbObject>("res"))
                    bundleWriter.Write(res.GetValue<byte[]>("resMeta"));
                foreach (DbObject res in bundleObj.GetValue<DbObject>("res"))
                    bundleWriter.Write(res.GetValue<long>("resRid"), endian);

                // chunks
                foreach (DbObject chunk in bundleObj.GetValue<DbObject>("chunks"))
                {
                    bundleWriter.Write(chunk.GetValue<Guid>("id"), endian);
                    bundleWriter.Write(chunk.GetValue<uint>("logicalOffset"), endian);
                    bundleWriter.Write(chunk.GetValue<uint>("logicalSize"), endian);
                }

                // meta
                long metaOffset = 0;
                long metaSize = 0;
                if (bundleObj.GetValue<DbObject>("chunkMeta") != null && bundleObj.GetValue<DbObject>("chunks").Count != 0)
                {
                    metaOffset = bundleWriter.Position + 0x20;
                    using (DbWriter metaWriter = new DbWriter(new MemoryStream()))
                        bundleWriter.Write(metaWriter.WriteDbObject("chunkMeta", bundleObj.GetValue<DbObject>("chunkMeta")));
                    metaSize = ((bundleWriter.Position + 0x20) - metaOffset);
                }

                // strings
                long stringsOffset = bundleWriter.Position + 0x20;
                foreach (string str in stringsToPrint)
                    bundleWriter.WriteNullTerminatedString(str);

                while ((bundleWriter.Position + 0x24) % 16 != 0)
                    bundleWriter.Write((byte)0x00);

                // update all relevant offsets
                writer.Position = startPos + 0x14;
                writer.Write((uint)stringsOffset, endian);
                writer.Write((uint)metaOffset, endian);
                writer.Write((uint)metaSize, endian);
            }

            // Compress bundle if necessary
            byte[] buffer = new byte[ms.Length];
            if (BaseBinarySb.GetMagic() == BaseBinarySb.Magic.Encrypted)
            {
                byte[] key = KeyManager.Instance.GetKey("Key2");

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = key;
                    aes.Padding = PaddingMode.None;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    using (CryptoStream cryptoStream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        cryptoStream.Write(buffer, 0, buffer.Length);
                }
            }
            else
                buffer = ms.ToArray();

            ms.Dispose();
            writer.Position = startPos - 4;
            writer.Write(buffer.Length + 0x20, Endian.Big);
            writer.Position = startPos + 0x20;
            writer.Write(buffer);
        }
    }
}
