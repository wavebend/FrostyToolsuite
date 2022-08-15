using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBasicManeuverBehaviourEntityData))]
	public class IncomSquadronAIBasicManeuverBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBasicManeuverBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBasicManeuverBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBasicManeuverBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIBasicManeuverBehaviour";

		public IncomSquadronAIBasicManeuverBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIBasicManeuverBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

