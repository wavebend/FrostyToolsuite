using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PrivateMatchLobbyEntityData))]
	public class PrivateMatchLobbyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PrivateMatchLobbyEntityData>
	{
		public new FrostySdk.Ebx.PrivateMatchLobbyEntityData Data => data as FrostySdk.Ebx.PrivateMatchLobbyEntityData;
		public override string DisplayName => "PrivateMatchLobby";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PrivateMatchLobbyEntity(FrostySdk.Ebx.PrivateMatchLobbyEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

