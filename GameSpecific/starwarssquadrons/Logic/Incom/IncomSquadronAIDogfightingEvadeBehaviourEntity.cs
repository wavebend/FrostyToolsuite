using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDogfightingEvadeBehaviourEntityData))]
	public class IncomSquadronAIDogfightingEvadeBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDogfightingEvadeBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDogfightingEvadeBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDogfightingEvadeBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIDogfightingEvadeBehaviour";

		public IncomSquadronAIDogfightingEvadeBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIDogfightingEvadeBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

