using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIHostedBehaviourEntityData))]
	public class IncomSquadronAIHostedBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIHostedBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIHostedBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIHostedBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIHostedBehaviour";

		public IncomSquadronAIHostedBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIHostedBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

