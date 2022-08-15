using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAdvancedManeuverBehaviourEntityData))]
	public class IncomSquadronAIAdvancedManeuverBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAdvancedManeuverBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAdvancedManeuverBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAdvancedManeuverBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIAdvancedManeuverBehaviour";

		public IncomSquadronAIAdvancedManeuverBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIAdvancedManeuverBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

