using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIProximateAreasBehaviourEntityData))]
	public class IncomSquadronAIProximateAreasBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIProximateAreasBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIProximateAreasBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIProximateAreasBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIProximateAreasBehaviour";

		public IncomSquadronAIProximateAreasBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIProximateAreasBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

