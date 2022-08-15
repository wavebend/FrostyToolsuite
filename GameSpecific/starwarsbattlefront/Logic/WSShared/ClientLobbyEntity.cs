using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientLobbyEntityData))]
	public class ClientLobbyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientLobbyEntityData>
	{
		public new FrostySdk.Ebx.ClientLobbyEntityData Data => data as FrostySdk.Ebx.ClientLobbyEntityData;
		public override string DisplayName => "ClientLobby";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientLobbyEntity(FrostySdk.Ebx.ClientLobbyEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

