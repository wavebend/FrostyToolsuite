using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIPathOverrideEntityData))]
	public class IncomSquadronAIPathOverrideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIPathOverrideEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIPathOverrideEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIPathOverrideEntityData;
		public override string DisplayName => "IncomSquadronAIPathOverride";

		public IncomSquadronAIPathOverrideEntity(FrostySdk.Ebx.IncomSquadronAIPathOverrideEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

