using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISelectorBehaviourEntityData))]
	public class IncomSquadronAISelectorBehaviourEntity : IncomSquadronAICompositeBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISelectorBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISelectorBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISelectorBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAISelectorBehaviour";

		public IncomSquadronAISelectorBehaviourEntity(FrostySdk.Ebx.IncomSquadronAISelectorBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

