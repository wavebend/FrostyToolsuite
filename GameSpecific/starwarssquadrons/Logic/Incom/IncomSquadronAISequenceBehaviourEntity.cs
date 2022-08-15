using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISequenceBehaviourEntityData))]
	public class IncomSquadronAISequenceBehaviourEntity : IncomSquadronAICompositeBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISequenceBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISequenceBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISequenceBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAISequenceBehaviour";

		public IncomSquadronAISequenceBehaviourEntity(FrostySdk.Ebx.IncomSquadronAISequenceBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

