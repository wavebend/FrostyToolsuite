using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerStarshipMovementControllerEntityData))]
	public class PlayerStarshipMovementControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerStarshipMovementControllerEntityData>
	{
		public new FrostySdk.Ebx.PlayerStarshipMovementControllerEntityData Data => data as FrostySdk.Ebx.PlayerStarshipMovementControllerEntityData;
		public override string DisplayName => "PlayerStarshipMovementController";

		public PlayerStarshipMovementControllerEntity(FrostySdk.Ebx.PlayerStarshipMovementControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

