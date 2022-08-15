using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BlueprintEventEntityData))]
	public class BlueprintEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BlueprintEventEntityData>
	{
		public new FrostySdk.Ebx.BlueprintEventEntityData Data => data as FrostySdk.Ebx.BlueprintEventEntityData;
		public override string DisplayName => "BlueprintEvent";

		public BlueprintEventEntity(FrostySdk.Ebx.BlueprintEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

