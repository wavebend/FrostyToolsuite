using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIProximateWaypointsBehaviourEntityData))]
	public class IncomSquadronAIProximateWaypointsBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIProximateWaypointsBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIProximateWaypointsBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIProximateWaypointsBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIProximateWaypointsBehaviour";

		public IncomSquadronAIProximateWaypointsBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIProximateWaypointsBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

