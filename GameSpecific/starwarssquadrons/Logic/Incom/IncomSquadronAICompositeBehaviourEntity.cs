using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICompositeBehaviourEntityData))]
	public class IncomSquadronAICompositeBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICompositeBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICompositeBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICompositeBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAICompositeBehaviour";

		public IncomSquadronAICompositeBehaviourEntity(FrostySdk.Ebx.IncomSquadronAICompositeBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

