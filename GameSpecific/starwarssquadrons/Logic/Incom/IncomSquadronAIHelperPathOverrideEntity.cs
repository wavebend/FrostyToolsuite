using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIHelperPathOverrideEntityData))]
	public class IncomSquadronAIHelperPathOverrideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIHelperPathOverrideEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIHelperPathOverrideEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIHelperPathOverrideEntityData;
		public override string DisplayName => "IncomSquadronAIHelperPathOverride";

		public IncomSquadronAIHelperPathOverrideEntity(FrostySdk.Ebx.IncomSquadronAIHelperPathOverrideEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

