using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBombingFlightBehaviourEntityData))]
	public class IncomSquadronAIBombingFlightBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBombingFlightBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBombingFlightBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBombingFlightBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIBombingFlightBehaviour";

		public IncomSquadronAIBombingFlightBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIBombingFlightBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

