using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ControllableAreaTriggerEntityData))]
	public class ControllableAreaTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ControllableAreaTriggerEntityData>
	{
		public new FrostySdk.Ebx.ControllableAreaTriggerEntityData Data => data as FrostySdk.Ebx.ControllableAreaTriggerEntityData;
		public override string DisplayName => "ControllableAreaTrigger";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ControllableAreaTriggerEntity(FrostySdk.Ebx.ControllableAreaTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

