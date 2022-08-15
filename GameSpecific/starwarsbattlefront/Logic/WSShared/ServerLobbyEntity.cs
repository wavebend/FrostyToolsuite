using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ServerLobbyEntityData))]
	public class ServerLobbyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ServerLobbyEntityData>
	{
		public new FrostySdk.Ebx.ServerLobbyEntityData Data => data as FrostySdk.Ebx.ServerLobbyEntityData;
		public override string DisplayName => "ServerLobby";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ServerLobbyEntity(FrostySdk.Ebx.ServerLobbyEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

