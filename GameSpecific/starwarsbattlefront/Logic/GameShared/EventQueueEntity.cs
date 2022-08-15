using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EventQueueEntityData))]
	public class EventQueueEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EventQueueEntityData>
	{
		public new FrostySdk.Ebx.EventQueueEntityData Data => data as FrostySdk.Ebx.EventQueueEntityData;
		public override string DisplayName => "EventQueue";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public EventQueueEntity(FrostySdk.Ebx.EventQueueEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

