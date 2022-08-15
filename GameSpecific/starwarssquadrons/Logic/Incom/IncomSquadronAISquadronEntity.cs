using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISquadronEntityData))]
	public class IncomSquadronAISquadronEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISquadronEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISquadronEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISquadronEntityData;
		public override string DisplayName => "IncomSquadronAISquadron";

		public IncomSquadronAISquadronEntity(FrostySdk.Ebx.IncomSquadronAISquadronEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

