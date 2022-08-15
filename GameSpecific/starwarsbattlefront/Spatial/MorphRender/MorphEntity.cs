using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MorphEntityData))]
	public class MorphEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.MorphEntityData>
	{
		public new FrostySdk.Ebx.MorphEntityData Data => data as FrostySdk.Ebx.MorphEntityData;

		public MorphEntity(FrostySdk.Ebx.MorphEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

