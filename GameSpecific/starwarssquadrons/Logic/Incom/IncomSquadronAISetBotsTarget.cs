using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISetBotsTargetData))]
	public class IncomSquadronAISetBotsTarget : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISetBotsTargetData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISetBotsTargetData Data => data as FrostySdk.Ebx.IncomSquadronAISetBotsTargetData;
		public override string DisplayName => "IncomSquadronAISetBotsTarget";

		public IncomSquadronAISetBotsTarget(FrostySdk.Ebx.IncomSquadronAISetBotsTargetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

