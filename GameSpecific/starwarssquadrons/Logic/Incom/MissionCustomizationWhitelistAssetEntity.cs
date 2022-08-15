using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MissionCustomizationWhitelistAssetEntityData))]
	public class MissionCustomizationWhitelistAssetEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MissionCustomizationWhitelistAssetEntityData>
	{
		public new FrostySdk.Ebx.MissionCustomizationWhitelistAssetEntityData Data => data as FrostySdk.Ebx.MissionCustomizationWhitelistAssetEntityData;
		public override string DisplayName => "MissionCustomizationWhitelistAsset";

		public MissionCustomizationWhitelistAssetEntity(FrostySdk.Ebx.MissionCustomizationWhitelistAssetEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

