using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAITimedBehaviourEntityData))]
	public class IncomSquadronAITimedBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAITimedBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAITimedBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAITimedBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAITimedBehaviour";

		public IncomSquadronAITimedBehaviourEntity(FrostySdk.Ebx.IncomSquadronAITimedBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

