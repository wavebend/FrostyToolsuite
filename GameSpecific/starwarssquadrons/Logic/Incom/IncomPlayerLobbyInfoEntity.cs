using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPlayerLobbyInfoEntityData))]
	public class IncomPlayerLobbyInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPlayerLobbyInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomPlayerLobbyInfoEntityData Data => data as FrostySdk.Ebx.IncomPlayerLobbyInfoEntityData;
		public override string DisplayName => "IncomPlayerLobbyInfo";

		public IncomPlayerLobbyInfoEntity(FrostySdk.Ebx.IncomPlayerLobbyInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

