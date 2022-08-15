using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubListsEntityData))]
	public class HubListsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubListsEntityData>
	{
		public new FrostySdk.Ebx.HubListsEntityData Data => data as FrostySdk.Ebx.HubListsEntityData;
		public override string DisplayName => "HubLists";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HubListsEntity(FrostySdk.Ebx.HubListsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

