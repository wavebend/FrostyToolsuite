using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaskVolumeEntityData))]
	public class MaskVolumeEntity : RenderVolumeEntity, IEntityData<FrostySdk.Ebx.MaskVolumeEntityData>
	{
		public new FrostySdk.Ebx.MaskVolumeEntityData Data => data as FrostySdk.Ebx.MaskVolumeEntityData;

		public MaskVolumeEntity(FrostySdk.Ebx.MaskVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

