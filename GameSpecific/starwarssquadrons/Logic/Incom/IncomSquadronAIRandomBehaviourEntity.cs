using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIRandomBehaviourEntityData))]
	public class IncomSquadronAIRandomBehaviourEntity : IncomSquadronAICompositeBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIRandomBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIRandomBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIRandomBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIRandomBehaviour";

		public IncomSquadronAIRandomBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIRandomBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

