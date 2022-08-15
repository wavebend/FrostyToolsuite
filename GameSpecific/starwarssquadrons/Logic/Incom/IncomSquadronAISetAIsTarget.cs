using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISetAIsTargetData))]
	public class IncomSquadronAISetAIsTarget : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISetAIsTargetData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISetAIsTargetData Data => data as FrostySdk.Ebx.IncomSquadronAISetAIsTargetData;
		public override string DisplayName => "IncomSquadronAISetAIsTarget";

		public IncomSquadronAISetAIsTarget(FrostySdk.Ebx.IncomSquadronAISetAIsTargetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

