using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSetMissionCompleteData))]
	public class IncomSetMissionComplete : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSetMissionCompleteData>
	{
		public new FrostySdk.Ebx.IncomSetMissionCompleteData Data => data as FrostySdk.Ebx.IncomSetMissionCompleteData;
		public override string DisplayName => "IncomSetMissionComplete";

		public IncomSetMissionComplete(FrostySdk.Ebx.IncomSetMissionCompleteData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

