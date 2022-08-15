using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDynamicSquadronSetupHelperData))]
	public class IncomSquadronAIDynamicSquadronSetupHelper : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDynamicSquadronSetupHelperData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDynamicSquadronSetupHelperData Data => data as FrostySdk.Ebx.IncomSquadronAIDynamicSquadronSetupHelperData;
		public override string DisplayName => "IncomSquadronAIDynamicSquadronSetupHelper";

		public IncomSquadronAIDynamicSquadronSetupHelper(FrostySdk.Ebx.IncomSquadronAIDynamicSquadronSetupHelperData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

