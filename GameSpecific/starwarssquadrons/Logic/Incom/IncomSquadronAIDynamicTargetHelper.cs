using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDynamicTargetHelperData))]
	public class IncomSquadronAIDynamicTargetHelper : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDynamicTargetHelperData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDynamicTargetHelperData Data => data as FrostySdk.Ebx.IncomSquadronAIDynamicTargetHelperData;
		public override string DisplayName => "IncomSquadronAIDynamicTargetHelper";

		public IncomSquadronAIDynamicTargetHelper(FrostySdk.Ebx.IncomSquadronAIDynamicTargetHelperData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

