using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDynamicTargetSectionHelperData))]
	public class IncomSquadronAIDynamicTargetSectionHelper : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDynamicTargetSectionHelperData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDynamicTargetSectionHelperData Data => data as FrostySdk.Ebx.IncomSquadronAIDynamicTargetSectionHelperData;
		public override string DisplayName => "IncomSquadronAIDynamicTargetSectionHelper";

		public IncomSquadronAIDynamicTargetSectionHelper(FrostySdk.Ebx.IncomSquadronAIDynamicTargetSectionHelperData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

