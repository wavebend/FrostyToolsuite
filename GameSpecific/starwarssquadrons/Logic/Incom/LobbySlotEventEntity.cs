using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LobbySlotEventEntityData))]
	public class LobbySlotEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LobbySlotEventEntityData>
	{
		public new FrostySdk.Ebx.LobbySlotEventEntityData Data => data as FrostySdk.Ebx.LobbySlotEventEntityData;
		public override string DisplayName => "LobbySlotEvent";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LobbySlotEventEntity(FrostySdk.Ebx.LobbySlotEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

