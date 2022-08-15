using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIEscapeAreasBehaviourEntityData))]
	public class IncomSquadronAIEscapeAreasBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIEscapeAreasBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIEscapeAreasBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIEscapeAreasBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIEscapeAreasBehaviour";

		public IncomSquadronAIEscapeAreasBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIEscapeAreasBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

