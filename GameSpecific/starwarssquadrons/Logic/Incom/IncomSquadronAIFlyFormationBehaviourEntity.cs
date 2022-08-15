using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIFlyFormationBehaviourEntityData))]
	public class IncomSquadronAIFlyFormationBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIFlyFormationBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIFlyFormationBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIFlyFormationBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIFlyFormationBehaviour";

		public IncomSquadronAIFlyFormationBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIFlyFormationBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

