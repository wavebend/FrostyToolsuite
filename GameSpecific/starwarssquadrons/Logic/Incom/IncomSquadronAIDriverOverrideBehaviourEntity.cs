using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDriverOverrideBehaviourEntityData))]
	public class IncomSquadronAIDriverOverrideBehaviourEntity : IncomSquadronAIHostedBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDriverOverrideBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDriverOverrideBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDriverOverrideBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIDriverOverrideBehaviour";

		public IncomSquadronAIDriverOverrideBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIDriverOverrideBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

