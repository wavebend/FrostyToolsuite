using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationEntityData))]
	public class IncomSquadronAIBotPhaseConfigurationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationEntityData;
		public override string DisplayName => "IncomSquadronAIBotPhaseConfiguration";

		public IncomSquadronAIBotPhaseConfigurationEntity(FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

