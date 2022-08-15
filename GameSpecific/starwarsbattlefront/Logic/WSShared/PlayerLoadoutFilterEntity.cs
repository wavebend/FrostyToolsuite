using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerLoadoutFilterEntityData))]
	public class PlayerLoadoutFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerLoadoutFilterEntityData>
	{
		public new FrostySdk.Ebx.PlayerLoadoutFilterEntityData Data => data as FrostySdk.Ebx.PlayerLoadoutFilterEntityData;
		public override string DisplayName => "PlayerLoadoutFilter";

		public PlayerLoadoutFilterEntity(FrostySdk.Ebx.PlayerLoadoutFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

