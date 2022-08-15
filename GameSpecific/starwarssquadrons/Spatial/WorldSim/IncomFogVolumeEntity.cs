using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomFogVolumeEntityData))]
	public class IncomFogVolumeEntity : LocalVolumetricEntity, IEntityData<FrostySdk.Ebx.IncomFogVolumeEntityData>
	{
		public new FrostySdk.Ebx.IncomFogVolumeEntityData Data => data as FrostySdk.Ebx.IncomFogVolumeEntityData;

		public IncomFogVolumeEntity(FrostySdk.Ebx.IncomFogVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

