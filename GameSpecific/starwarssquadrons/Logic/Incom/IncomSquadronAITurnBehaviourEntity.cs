using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAITurnBehaviourEntityData))]
	public class IncomSquadronAITurnBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAITurnBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAITurnBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAITurnBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAITurnBehaviour";

		public IncomSquadronAITurnBehaviourEntity(FrostySdk.Ebx.IncomSquadronAITurnBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

