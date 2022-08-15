using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIPingedTargetHelperData))]
	public class IncomSquadronAIPingedTargetHelper : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIPingedTargetHelperData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIPingedTargetHelperData Data => data as FrostySdk.Ebx.IncomSquadronAIPingedTargetHelperData;
		public override string DisplayName => "IncomSquadronAIPingedTargetHelper";

		public IncomSquadronAIPingedTargetHelper(FrostySdk.Ebx.IncomSquadronAIPingedTargetHelperData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

