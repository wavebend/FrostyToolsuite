using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceOverrideEntityData))]
	public class IncomSquadronAICollisionAvoidanceOverrideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceOverrideEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceOverrideEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceOverrideEntityData;
		public override string DisplayName => "IncomSquadronAICollisionAvoidanceOverride";

		public IncomSquadronAICollisionAvoidanceOverrideEntity(FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceOverrideEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

