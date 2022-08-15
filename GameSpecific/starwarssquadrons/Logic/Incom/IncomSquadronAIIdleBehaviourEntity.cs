using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIIdleBehaviourEntityData))]
	public class IncomSquadronAIIdleBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIIdleBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIIdleBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIIdleBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIIdleBehaviour";

		public IncomSquadronAIIdleBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIIdleBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

