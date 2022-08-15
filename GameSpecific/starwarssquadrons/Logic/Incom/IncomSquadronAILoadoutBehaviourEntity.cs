using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAILoadoutBehaviourEntityData))]
	public class IncomSquadronAILoadoutBehaviourEntity : IncomSquadronAIHostedBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAILoadoutBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAILoadoutBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAILoadoutBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAILoadoutBehaviour";

		public IncomSquadronAILoadoutBehaviourEntity(FrostySdk.Ebx.IncomSquadronAILoadoutBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

