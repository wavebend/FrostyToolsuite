using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITeamColorEntityData))]
	public class UITeamColorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UITeamColorEntityData>
	{
		public new FrostySdk.Ebx.UITeamColorEntityData Data => data as FrostySdk.Ebx.UITeamColorEntityData;
		public override string DisplayName => "UITeamColor";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UITeamColorEntity(FrostySdk.Ebx.UITeamColorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

