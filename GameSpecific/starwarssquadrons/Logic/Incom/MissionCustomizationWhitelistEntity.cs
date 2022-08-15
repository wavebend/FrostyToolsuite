using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MissionCustomizationWhitelistEntityData))]
	public class MissionCustomizationWhitelistEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MissionCustomizationWhitelistEntityData>
	{
		public new FrostySdk.Ebx.MissionCustomizationWhitelistEntityData Data => data as FrostySdk.Ebx.MissionCustomizationWhitelistEntityData;
		public override string DisplayName => "MissionCustomizationWhitelist";

		public MissionCustomizationWhitelistEntity(FrostySdk.Ebx.MissionCustomizationWhitelistEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

