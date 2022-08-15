using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubInteractionEntityData))]
	public class HubInteractionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubInteractionEntityData>
	{
		public new FrostySdk.Ebx.HubInteractionEntityData Data => data as FrostySdk.Ebx.HubInteractionEntityData;
		public override string DisplayName => "HubInteraction";

		public HubInteractionEntity(FrostySdk.Ebx.HubInteractionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

