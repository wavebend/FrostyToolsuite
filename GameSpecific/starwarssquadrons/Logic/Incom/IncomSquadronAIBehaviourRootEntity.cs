using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBehaviourRootEntityData))]
	public class IncomSquadronAIBehaviourRootEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBehaviourRootEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBehaviourRootEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBehaviourRootEntityData;
		public override string DisplayName => "IncomSquadronAIBehaviourRoot";

		public IncomSquadronAIBehaviourRootEntity(FrostySdk.Ebx.IncomSquadronAIBehaviourRootEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

