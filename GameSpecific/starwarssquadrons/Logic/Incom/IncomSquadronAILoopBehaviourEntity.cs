using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAILoopBehaviourEntityData))]
	public class IncomSquadronAILoopBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAILoopBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAILoopBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAILoopBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAILoopBehaviour";

		public IncomSquadronAILoopBehaviourEntity(FrostySdk.Ebx.IncomSquadronAILoopBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

