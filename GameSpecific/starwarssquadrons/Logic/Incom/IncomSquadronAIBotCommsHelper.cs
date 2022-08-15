using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBotCommsHelperData))]
	public class IncomSquadronAIBotCommsHelper : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBotCommsHelperData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBotCommsHelperData Data => data as FrostySdk.Ebx.IncomSquadronAIBotCommsHelperData;
		public override string DisplayName => "IncomSquadronAIBotCommsHelper";

		public IncomSquadronAIBotCommsHelper(FrostySdk.Ebx.IncomSquadronAIBotCommsHelperData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

