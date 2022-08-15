using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAfterburnerBehaviourEntityData))]
	public class IncomSquadronAIAfterburnerBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAfterburnerBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAfterburnerBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAfterburnerBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIAfterburnerBehaviour";

		public IncomSquadronAIAfterburnerBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIAfterburnerBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

