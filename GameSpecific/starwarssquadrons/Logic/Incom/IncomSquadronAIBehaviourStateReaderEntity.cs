using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBehaviourStateReaderEntityData))]
	public class IncomSquadronAIBehaviourStateReaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBehaviourStateReaderEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBehaviourStateReaderEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBehaviourStateReaderEntityData;
		public override string DisplayName => "IncomSquadronAIBehaviourStateReader";

		public IncomSquadronAIBehaviourStateReaderEntity(FrostySdk.Ebx.IncomSquadronAIBehaviourStateReaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

