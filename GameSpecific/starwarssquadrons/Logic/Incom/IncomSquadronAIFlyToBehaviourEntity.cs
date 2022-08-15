using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIFlyToBehaviourEntityData))]
	public class IncomSquadronAIFlyToBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIFlyToBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIFlyToBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIFlyToBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIFlyToBehaviour";

		public IncomSquadronAIFlyToBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIFlyToBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

