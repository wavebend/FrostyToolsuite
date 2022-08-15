using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomObjectAreaTriggerEntityData))]
	public class IncomObjectAreaTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomObjectAreaTriggerEntityData>
	{
		public new FrostySdk.Ebx.IncomObjectAreaTriggerEntityData Data => data as FrostySdk.Ebx.IncomObjectAreaTriggerEntityData;
		public override string DisplayName => "IncomObjectAreaTrigger";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomObjectAreaTriggerEntity(FrostySdk.Ebx.IncomObjectAreaTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

