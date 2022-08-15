using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerJoinStateEntityData))]
	public class PlayerJoinStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerJoinStateEntityData>
	{
		public new FrostySdk.Ebx.PlayerJoinStateEntityData Data => data as FrostySdk.Ebx.PlayerJoinStateEntityData;
		public override string DisplayName => "PlayerJoinState";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerJoinStateEntity(FrostySdk.Ebx.PlayerJoinStateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

