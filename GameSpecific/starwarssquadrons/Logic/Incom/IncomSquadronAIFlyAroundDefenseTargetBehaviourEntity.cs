using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIFlyAroundDefenseTargetBehaviourEntityData))]
	public class IncomSquadronAIFlyAroundDefenseTargetBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIFlyAroundDefenseTargetBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIFlyAroundDefenseTargetBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIFlyAroundDefenseTargetBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIFlyAroundDefenseTargetBehaviour";

		public IncomSquadronAIFlyAroundDefenseTargetBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIFlyAroundDefenseTargetBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

