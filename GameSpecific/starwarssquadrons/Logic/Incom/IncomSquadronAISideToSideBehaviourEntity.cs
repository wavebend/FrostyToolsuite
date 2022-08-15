using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISideToSideBehaviourEntityData))]
	public class IncomSquadronAISideToSideBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISideToSideBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISideToSideBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISideToSideBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAISideToSideBehaviour";

		public IncomSquadronAISideToSideBehaviourEntity(FrostySdk.Ebx.IncomSquadronAISideToSideBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

