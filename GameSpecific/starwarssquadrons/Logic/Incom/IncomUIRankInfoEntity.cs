using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIRankInfoEntityData))]
	public class IncomUIRankInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIRankInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomUIRankInfoEntityData Data => data as FrostySdk.Ebx.IncomUIRankInfoEntityData;
		public override string DisplayName => "IncomUIRankInfo";

		public IncomUIRankInfoEntity(FrostySdk.Ebx.IncomUIRankInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

