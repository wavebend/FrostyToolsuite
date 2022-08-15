using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAITargetProviderEntityData))]
	public class IncomSquadronAITargetProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAITargetProviderEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAITargetProviderEntityData Data => data as FrostySdk.Ebx.IncomSquadronAITargetProviderEntityData;
		public override string DisplayName => "IncomSquadronAITargetProvider";

		public IncomSquadronAITargetProviderEntity(FrostySdk.Ebx.IncomSquadronAITargetProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

