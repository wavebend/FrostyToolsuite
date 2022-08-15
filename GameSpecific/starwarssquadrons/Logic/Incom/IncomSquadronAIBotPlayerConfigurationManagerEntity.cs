using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBotPlayerConfigurationManagerEntityData))]
	public class IncomSquadronAIBotPlayerConfigurationManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBotPlayerConfigurationManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBotPlayerConfigurationManagerEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBotPlayerConfigurationManagerEntityData;
		public override string DisplayName => "IncomSquadronAIBotPlayerConfigurationManager";

		public IncomSquadronAIBotPlayerConfigurationManagerEntity(FrostySdk.Ebx.IncomSquadronAIBotPlayerConfigurationManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

