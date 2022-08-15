using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompanionSettingsEntityData))]
	public class CompanionSettingsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CompanionSettingsEntityData>
	{
		public new FrostySdk.Ebx.CompanionSettingsEntityData Data => data as FrostySdk.Ebx.CompanionSettingsEntityData;
		public override string DisplayName => "CompanionSettings";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CompanionSettingsEntity(FrostySdk.Ebx.CompanionSettingsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

