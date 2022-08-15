using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DestructionMaskVolumeEntityData))]
	public class DestructionMaskVolumeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.DestructionMaskVolumeEntityData>
	{
		public new FrostySdk.Ebx.DestructionMaskVolumeEntityData Data => data as FrostySdk.Ebx.DestructionMaskVolumeEntityData;

		public DestructionMaskVolumeEntity(FrostySdk.Ebx.DestructionMaskVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

