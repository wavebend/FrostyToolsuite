using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ServerCustomGameRestartEntityData))]
	public class ServerCustomGameRestartEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ServerCustomGameRestartEntityData>
	{
		public new FrostySdk.Ebx.ServerCustomGameRestartEntityData Data => data as FrostySdk.Ebx.ServerCustomGameRestartEntityData;
		public override string DisplayName => "ServerCustomGameRestart";

		public ServerCustomGameRestartEntity(FrostySdk.Ebx.ServerCustomGameRestartEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

