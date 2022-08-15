using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomMissionListData))]
	public class IncomMissionList : LogicEntity, IEntityData<FrostySdk.Ebx.IncomMissionListData>
	{
		public new FrostySdk.Ebx.IncomMissionListData Data => data as FrostySdk.Ebx.IncomMissionListData;
		public override string DisplayName => "IncomMissionList";

		public IncomMissionList(FrostySdk.Ebx.IncomMissionListData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

