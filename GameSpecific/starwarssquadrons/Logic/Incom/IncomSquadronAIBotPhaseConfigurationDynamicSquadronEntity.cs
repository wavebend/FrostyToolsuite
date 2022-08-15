using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntityData))]
	public class IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntity : IncomSquadronAIDynamicSquadronEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntityData;
		public override string DisplayName => "IncomSquadronAIBotPhaseConfigurationDynamicSquadron";

		public IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntity(FrostySdk.Ebx.IncomSquadronAIBotPhaseConfigurationDynamicSquadronEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

