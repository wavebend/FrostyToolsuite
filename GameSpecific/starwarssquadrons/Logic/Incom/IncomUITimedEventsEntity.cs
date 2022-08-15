using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUITimedEventsEntityData))]
	public class IncomUITimedEventsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUITimedEventsEntityData>
	{
		public new FrostySdk.Ebx.IncomUITimedEventsEntityData Data => data as FrostySdk.Ebx.IncomUITimedEventsEntityData;
		public override string DisplayName => "IncomUITimedEvents";

		public IncomUITimedEventsEntity(FrostySdk.Ebx.IncomUITimedEventsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

