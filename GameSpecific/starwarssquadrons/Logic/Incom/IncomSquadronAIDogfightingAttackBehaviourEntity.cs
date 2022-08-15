using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDogfightingAttackBehaviourEntityData))]
	public class IncomSquadronAIDogfightingAttackBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDogfightingAttackBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDogfightingAttackBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDogfightingAttackBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIDogfightingAttackBehaviour";

		public IncomSquadronAIDogfightingAttackBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIDogfightingAttackBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

