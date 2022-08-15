using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LobbyControllerEntityData))]
	public class LobbyControllerEntity : BaseControllerEntity, IEntityData<FrostySdk.Ebx.LobbyControllerEntityData>
	{
		public new FrostySdk.Ebx.LobbyControllerEntityData Data => data as FrostySdk.Ebx.LobbyControllerEntityData;
		public override string DisplayName => "LobbyController";

		public LobbyControllerEntity(FrostySdk.Ebx.LobbyControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

