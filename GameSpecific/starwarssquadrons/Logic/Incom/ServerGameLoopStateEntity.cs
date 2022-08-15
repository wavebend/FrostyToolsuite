using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ServerGameLoopStateEntityData))]
	public class ServerGameLoopStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ServerGameLoopStateEntityData>
	{
		public new FrostySdk.Ebx.ServerGameLoopStateEntityData Data => data as FrostySdk.Ebx.ServerGameLoopStateEntityData;
		public override string DisplayName => "ServerGameLoopState";

		public ServerGameLoopStateEntity(FrostySdk.Ebx.ServerGameLoopStateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

