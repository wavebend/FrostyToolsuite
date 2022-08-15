using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDynamicSquadronEntityData))]
	public class IncomSquadronAIDynamicSquadronEntity : IncomSquadronAISquadronEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDynamicSquadronEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDynamicSquadronEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDynamicSquadronEntityData;
		public override string DisplayName => "IncomSquadronAIDynamicSquadron";

		public IncomSquadronAIDynamicSquadronEntity(FrostySdk.Ebx.IncomSquadronAIDynamicSquadronEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

