using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubEventsEntityData))]
	public class HubEventsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubEventsEntityData>
	{
		public new FrostySdk.Ebx.HubEventsEntityData Data => data as FrostySdk.Ebx.HubEventsEntityData;
		public override string DisplayName => "HubEvents";

		public HubEventsEntity(FrostySdk.Ebx.HubEventsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

