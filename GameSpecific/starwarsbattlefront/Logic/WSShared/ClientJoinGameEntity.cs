using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientJoinGameEntityData))]
	public class ClientJoinGameEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientJoinGameEntityData>
	{
		public new FrostySdk.Ebx.ClientJoinGameEntityData Data => data as FrostySdk.Ebx.ClientJoinGameEntityData;
		public override string DisplayName => "ClientJoinGame";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientJoinGameEntity(FrostySdk.Ebx.ClientJoinGameEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

