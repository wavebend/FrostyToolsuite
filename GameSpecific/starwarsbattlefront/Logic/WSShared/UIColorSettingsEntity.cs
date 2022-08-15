using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIColorSettingsEntityData))]
	public class UIColorSettingsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIColorSettingsEntityData>
	{
		public new FrostySdk.Ebx.UIColorSettingsEntityData Data => data as FrostySdk.Ebx.UIColorSettingsEntityData;
		public override string DisplayName => "UIColorSettings";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UIColorSettingsEntity(FrostySdk.Ebx.UIColorSettingsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

