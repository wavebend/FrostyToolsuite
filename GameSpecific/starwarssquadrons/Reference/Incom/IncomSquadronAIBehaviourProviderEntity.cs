using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBehaviourProviderEntityData))]
	public class IncomSquadronAIBehaviourProviderEntity : LogicReferenceObject, IEntityData<FrostySdk.Ebx.IncomSquadronAIBehaviourProviderEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBehaviourProviderEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBehaviourProviderEntityData;

		public IncomSquadronAIBehaviourProviderEntity(FrostySdk.Ebx.IncomSquadronAIBehaviourProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

