using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FriendsOnServerEntityData))]
	public class FriendsOnServerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FriendsOnServerEntityData>
	{
		public new FrostySdk.Ebx.FriendsOnServerEntityData Data => data as FrostySdk.Ebx.FriendsOnServerEntityData;
		public override string DisplayName => "FriendsOnServer";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public FriendsOnServerEntity(FrostySdk.Ebx.FriendsOnServerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

