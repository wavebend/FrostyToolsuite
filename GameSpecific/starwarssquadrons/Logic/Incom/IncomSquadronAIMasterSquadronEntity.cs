using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIMasterSquadronEntityData))]
	public class IncomSquadronAIMasterSquadronEntity : IncomSquadronAIDynamicSquadronEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIMasterSquadronEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIMasterSquadronEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIMasterSquadronEntityData;
		public override string DisplayName => "IncomSquadronAIMasterSquadron";

		public IncomSquadronAIMasterSquadronEntity(FrostySdk.Ebx.IncomSquadronAIMasterSquadronEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

