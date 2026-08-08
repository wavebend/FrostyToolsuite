using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostySdk.IO
{

    public class EbxSharedTypeDescriptors
    {
        public int ClassCount => classes.Count;
        public bool HasReflectionIds => reflectionIds.Count != 0;

        private List<EbxClass?> classes = new List<EbxClass?>();
        private Dictionary<Guid, int> mapping = new Dictionary<Guid, int>();
        private List<EbxField?> fields = new List<EbxField?>();
        private List<Guid?> typeInfoGuids = new List<Guid?>();
        private Dictionary<ulong, ReflectionIdEntry> reflectionIds = new Dictionary<ulong, ReflectionIdEntry>();

        private struct ReflectionIdEntry
        {
            public uint Id;
            public int PathLength;
            public int PathIndex;
        }

        private struct ReflectionField
        {
            public uint NameHash;
            public int ClassIndex;
        }

        public EbxSharedTypeDescriptors(FileSystemManager fs, string name)
        {
            bool patch = name.Contains("patch");
            using (NativeReader reader = new NativeReader(new MemoryStream(fs.GetFileFromMemoryFs(name))))
            {
                EbxVersion magic = (EbxVersion)reader.ReadUInt();
                if (magic == EbxVersion.Version4)
                    ReadV1(reader, patch);
                else if (magic == EbxVersion.Version6)
                    ReadRiff(reader, patch);
            }
        }

        private void ReadV1(NativeReader reader, bool patch)
        {
            ushort numClasses = reader.ReadUShort();
            ushort numFields = reader.ReadUShort();

            for (int i = 0; i < numFields; i++)
            {
                uint hash = reader.ReadUInt();

                EbxField field = new EbxField
                {
                    NameHash = hash,
                    Type = (ushort)(reader.ReadUShort() >> 1),
                    ClassRef = reader.ReadUShort(),
                    DataOffset = reader.ReadUInt(),
                    SecondOffset = reader.ReadUInt()
                };
                fields.Add(field);
            }

            int fieldIdx = 0;
            for (int i = 0; i < numClasses; i++)
            {
                long classOffset = reader.Position;

                Guid guid = reader.ReadGuid();
                Guid guid2 = reader.ReadGuid();

                if (guid == guid2)
                {
                    mapping.Add(guid, classes.Count);
                    classes.Add(null);
                    typeInfoGuids.Add(guid);
                    continue;
                }

                reader.Position -= 0x10;
                uint hash = reader.ReadUInt();
                uint fieldOffset = reader.ReadUInt();
                int fieldCount = reader.ReadByte();
                byte alignment = reader.ReadByte();
                ushort type = reader.ReadUShort();
                uint size = reader.ReadUInt();

                if ((alignment & 0x80) != 0)
                {
                    fieldCount += 0x100;
                    alignment &= 0x7F;
                }

                EbxClass ebxClass = new EbxClass
                {
                    NameHash = hash,
                    FieldIndex = (int)((classOffset - (fieldOffset - 0x08)) / 0x10),
                    FieldCount = (byte)fieldCount,
                    Alignment = alignment,
                    Size = (ushort)(size),
                    Type = (ushort)(type >> 1),
                    Index = i
                };
                if (patch)
                {
                    ebxClass.SecondSize = 1;
                }

                mapping.Add(guid, classes.Count);
                classes.Add(ebxClass);
                typeInfoGuids.Add(guid);

                fieldIdx += fieldCount;
            }
        }

        private void ReadRiff(NativeReader reader, bool patch)
        {
            uint fileSize = reader.ReadUInt();

            if (reader.ReadUInt(Endian.Big) != 0x45425854)
                throw new InvalidDataException("Not valid EBXT.");

            if (reader.ReadUInt(Endian.Big) != 0x5245464C)
                throw new InvalidDataException("Not valid REFL chunk.");
            uint reflSize = reader.ReadUInt();
            long reflEnd = reader.Position + reflSize;

            int classGuidCount = reader.ReadInt();

            for (int i = 0; i < classGuidCount; i++)
            {
                Guid classGuid = reader.ReadGuid();
                reader.Position -= 12;
                Guid typeInfoGuid = reader.ReadGuid();

                mapping.Add(typeInfoGuid, i);
                typeInfoGuids.Add(typeInfoGuid);
            }

            int numClasses = reader.ReadInt();
            for (int i = 0; i < numClasses; i++)
            {
                classes.Add(new EbxClass
                {
                    NameHash = reader.ReadUInt(),
                    FieldIndex = reader.ReadInt(),
                    FieldCount = reader.ReadUShort(),
                    Type = (ushort)(reader.ReadUShort() >> 1),
                    Size = reader.ReadUShort(),
                    Alignment = (byte)reader.ReadUShort(),
                    Index = i,
                    SecondSize = (ushort)(patch ? 1 : 0)
                });
            }

            for (int i = numClasses; i < classGuidCount; i++)
            {
                classes.Add(null);
            }

            int numFields = reader.ReadInt();
            for (int i = 0; i < numFields; i++)
            {
                fields.Add(new EbxField
                {
                    NameHash = reader.ReadUInt(),
                    DataOffset = reader.ReadUInt(),
                    Type = (ushort)(reader.ReadUShort() >> 1),
                    ClassRef = reader.ReadUShort()
                });
            }

            ReadReflectionIds(reader, reflEnd);
        }

        private void ReadReflectionIds(NativeReader reader, long reflEnd)
        {
            // Older shared descriptor files end after the field table.
            if (reader.Position + sizeof(int) > reflEnd)
            {
                return;
            }

            int reflectionIdCount = reader.ReadInt();
            if (reflectionIdCount < 0 || reader.Position + ((long)reflectionIdCount * 12) > reflEnd)
            {
                return;
            }

            List<ReflectionIdEntry> entries = new List<ReflectionIdEntry>(reflectionIdCount);
            for (int i = 0; i < reflectionIdCount; i++)
            {
                entries.Add(new ReflectionIdEntry
                {
                    Id = reader.ReadUInt(),
                    PathLength = reader.ReadInt(),
                    PathIndex = reader.ReadInt()
                });
            }

            if (reader.Position + sizeof(int) > reflEnd)
            {
                return;
            }

            int reflectionFieldCount = reader.ReadInt();
            if (reflectionFieldCount < 0 || reader.Position + ((long)reflectionFieldCount * 8) > reflEnd)
            {
                return;
            }

            List<ReflectionField> reflectionFields = new List<ReflectionField>(reflectionFieldCount);
            for (int i = 0; i < reflectionFieldCount; i++)
            {
                reflectionFields.Add(new ReflectionField
                {
                    NameHash = reader.ReadUInt(),
                    ClassIndex = reader.ReadInt()
                });
            }

            foreach (ReflectionIdEntry entry in entries)
            {
                if (entry.PathLength <= 0
                    || entry.PathIndex < 0
                    || (long)entry.PathIndex + entry.PathLength > reflectionFields.Count)
                {
                    continue;
                }

                ReflectionField terminal = reflectionFields[entry.PathIndex + entry.PathLength - 1];
                if (terminal.ClassIndex < 0 || terminal.ClassIndex >= classes.Count)
                {
                    continue;
                }

                ulong key = GetReflectionFieldKey(terminal.ClassIndex, terminal.NameHash);
                if (!reflectionIds.TryGetValue(key, out ReflectionIdEntry current)
                    || IsPreferredReflectionId(entry, current))
                {
                    reflectionIds[key] = entry;
                }
            }
        }

        private static bool IsPreferredReflectionId(ReflectionIdEntry candidate, ReflectionIdEntry current)
        {
            return candidate.PathLength < current.PathLength
                || (candidate.PathLength == current.PathLength && candidate.Id < current.Id);
        }

        private static ulong GetReflectionFieldKey(int classIndex, uint nameHash)
        {
            return ((ulong)(uint)classIndex << 32) | nameHash;
        }

        public bool HasClass(Guid guid) => mapping.ContainsKey(guid);

        public EbxClass? GetClass(Guid guid) => !mapping.ContainsKey(guid) ? null : classes[mapping[guid]];

        public EbxClass? GetClass(int index) => index >= 0 && index < classes.Count ? classes[index] : null;

        public Guid? GetGuid(EbxClass classType) => classType.Index >= 0 && classType.Index < typeInfoGuids.Count ? typeInfoGuids[classType.Index] : null;

        public Guid? GetGuid(int index) => index >= 0 && index < typeInfoGuids.Count ? typeInfoGuids[index] : null;

        public EbxField? GetField(int index) => index >= 0 && index < fields.Count ? fields[index] : null;

        public bool TryGetReflectionId(EbxClass classType, uint fieldNameHash, out uint reflectionId)
        {
            EbxClass? descriptorClass = GetClass(classType.Index);
            if (descriptorClass.HasValue
                && descriptorClass.Value.NameHash == classType.NameHash
                && reflectionIds.TryGetValue(
                    GetReflectionFieldKey(classType.Index, fieldNameHash),
                    out ReflectionIdEntry entry))
            {
                reflectionId = entry.Id;
                return true;
            }

            reflectionId = 0;
            return false;
        }
    }
}
