using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIRecoveryLocatorEntityData))]
	public class IncomSquadronAIRecoveryLocatorEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIRecoveryLocatorEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIRecoveryLocatorEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIRecoveryLocatorEntityData;

		public IncomSquadronAIRecoveryLocatorEntity(FrostySdk.Ebx.IncomSquadronAIRecoveryLocatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

