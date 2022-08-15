using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrossplayFriendEntityData))]
	public class CrossplayFriendEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CrossplayFriendEntityData>
	{
		public new FrostySdk.Ebx.CrossplayFriendEntityData Data => data as FrostySdk.Ebx.CrossplayFriendEntityData;
		public override string DisplayName => "CrossplayFriend";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CrossplayFriendEntity(FrostySdk.Ebx.CrossplayFriendEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

