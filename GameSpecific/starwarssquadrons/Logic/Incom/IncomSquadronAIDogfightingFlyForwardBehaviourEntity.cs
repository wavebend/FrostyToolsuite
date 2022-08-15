using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDogfightingFlyForwardBehaviourEntityData))]
	public class IncomSquadronAIDogfightingFlyForwardBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDogfightingFlyForwardBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDogfightingFlyForwardBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDogfightingFlyForwardBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIDogfightingFlyForwardBehaviour";

		public IncomSquadronAIDogfightingFlyForwardBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIDogfightingFlyForwardBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

