using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBehaviourEntityData))]
	public class IncomSquadronAIBehaviourEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIBehaviour";

		public IncomSquadronAIBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

