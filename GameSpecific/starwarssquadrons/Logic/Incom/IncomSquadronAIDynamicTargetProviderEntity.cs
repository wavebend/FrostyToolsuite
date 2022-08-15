using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDynamicTargetProviderEntityData))]
	public class IncomSquadronAIDynamicTargetProviderEntity : IncomSquadronAITargetProviderEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDynamicTargetProviderEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDynamicTargetProviderEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDynamicTargetProviderEntityData;
		public override string DisplayName => "IncomSquadronAIDynamicTargetProvider";

		public IncomSquadronAIDynamicTargetProviderEntity(FrostySdk.Ebx.IncomSquadronAIDynamicTargetProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

