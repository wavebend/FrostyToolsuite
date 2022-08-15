using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetConfigItemInfoData))]
	public class GetConfigItemInfo : LogicEntity, IEntityData<FrostySdk.Ebx.GetConfigItemInfoData>
	{
		public new FrostySdk.Ebx.GetConfigItemInfoData Data => data as FrostySdk.Ebx.GetConfigItemInfoData;
		public override string DisplayName => "GetConfigItemInfo";

		public GetConfigItemInfo(FrostySdk.Ebx.GetConfigItemInfoData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

