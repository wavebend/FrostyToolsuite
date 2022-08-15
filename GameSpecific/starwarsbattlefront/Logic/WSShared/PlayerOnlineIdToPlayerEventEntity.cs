using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerOnlineIdToPlayerEventEntityData))]
	public class PlayerOnlineIdToPlayerEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerOnlineIdToPlayerEventEntityData>
	{
		public new FrostySdk.Ebx.PlayerOnlineIdToPlayerEventEntityData Data => data as FrostySdk.Ebx.PlayerOnlineIdToPlayerEventEntityData;
		public override string DisplayName => "PlayerOnlineIdToPlayerEvent";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerOnlineIdToPlayerEventEntity(FrostySdk.Ebx.PlayerOnlineIdToPlayerEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

