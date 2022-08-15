using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIFollowWaypointsBehaviourEntityData))]
	public class IncomSquadronAIFollowWaypointsBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIFollowWaypointsBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIFollowWaypointsBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIFollowWaypointsBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIFollowWaypointsBehaviour";

		public IncomSquadronAIFollowWaypointsBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIFollowWaypointsBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

