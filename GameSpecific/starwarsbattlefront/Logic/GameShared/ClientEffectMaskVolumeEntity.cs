using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientEffectMaskVolumeEntityData))]
	public class ClientEffectMaskVolumeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientEffectMaskVolumeEntityData>
	{
		public new FrostySdk.Ebx.ClientEffectMaskVolumeEntityData Data => data as FrostySdk.Ebx.ClientEffectMaskVolumeEntityData;
		public override string DisplayName => "ClientEffectMaskVolume";

		public ClientEffectMaskVolumeEntity(FrostySdk.Ebx.ClientEffectMaskVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

