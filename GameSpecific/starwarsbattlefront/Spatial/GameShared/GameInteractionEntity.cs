using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameInteractionEntityData))]
	public class GameInteractionEntity : InteractionEntity, IEntityData<FrostySdk.Ebx.GameInteractionEntityData>
	{
		public new FrostySdk.Ebx.GameInteractionEntityData Data => data as FrostySdk.Ebx.GameInteractionEntityData;

		public GameInteractionEntity(FrostySdk.Ebx.GameInteractionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

