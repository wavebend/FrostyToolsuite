using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditorPlugin.Entities
{
    [EntityBinding(DataType = typeof(FrostySdk.Ebx.WorldPartReferenceObjectData))]
#if SWBF
    public class WorldPartReferenceObject : ReferenceObject, IEntityData<FrostySdk.Ebx.WorldPartReferenceObjectData>
#else
    public class WorldPartReferenceObject : LayerReferenceObject, IEntityData<FrostySdk.Ebx.WorldPartReferenceObjectData>
#endif
    {
        public new FrostySdk.Ebx.WorldPartReferenceObjectData Data => data as FrostySdk.Ebx.WorldPartReferenceObjectData;
        public new Assets.WorldPart Blueprint => blueprint as Assets.WorldPart;

        public WorldPartReferenceObject(FrostySdk.Ebx.WorldPartReferenceObjectData inData, Entity inParent)
            : base(inData, inParent)
        {
        }
    }
}
