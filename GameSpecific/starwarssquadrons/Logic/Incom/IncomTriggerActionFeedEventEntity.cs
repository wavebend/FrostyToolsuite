using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomTriggerActionFeedEventEntityData))]
	public class IncomTriggerActionFeedEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomTriggerActionFeedEventEntityData>
	{
		public new FrostySdk.Ebx.IncomTriggerActionFeedEventEntityData Data => data as FrostySdk.Ebx.IncomTriggerActionFeedEventEntityData;
		public override string DisplayName => "IncomTriggerActionFeedEvent";

		public IncomTriggerActionFeedEventEntity(FrostySdk.Ebx.IncomTriggerActionFeedEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

