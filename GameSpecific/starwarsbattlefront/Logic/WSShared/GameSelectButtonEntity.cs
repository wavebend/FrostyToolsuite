using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameSelectButtonEntityData))]
	public class GameSelectButtonEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GameSelectButtonEntityData>
	{
		public new FrostySdk.Ebx.GameSelectButtonEntityData Data => data as FrostySdk.Ebx.GameSelectButtonEntityData;
		public override string DisplayName => "GameSelectButton";

		public GameSelectButtonEntity(FrostySdk.Ebx.GameSelectButtonEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

