using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINavigationEventsEntityData))]
	public class UINavigationEventsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UINavigationEventsEntityData>
	{
		public new FrostySdk.Ebx.UINavigationEventsEntityData Data => data as FrostySdk.Ebx.UINavigationEventsEntityData;
		public override string DisplayName => "UINavigationEvents";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UINavigationEventsEntity(FrostySdk.Ebx.UINavigationEventsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

