using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ServerEndOfRoundMatchmakingEntityData))]
	public class ServerEndOfRoundMatchmakingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ServerEndOfRoundMatchmakingEntityData>
	{
		public new FrostySdk.Ebx.ServerEndOfRoundMatchmakingEntityData Data => data as FrostySdk.Ebx.ServerEndOfRoundMatchmakingEntityData;
		public override string DisplayName => "ServerEndOfRoundMatchmaking";

		public ServerEndOfRoundMatchmakingEntity(FrostySdk.Ebx.ServerEndOfRoundMatchmakingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

