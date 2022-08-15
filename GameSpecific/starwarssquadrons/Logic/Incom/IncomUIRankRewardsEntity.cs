using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIRankRewardsEntityData))]
	public class IncomUIRankRewardsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIRankRewardsEntityData>
	{
		public new FrostySdk.Ebx.IncomUIRankRewardsEntityData Data => data as FrostySdk.Ebx.IncomUIRankRewardsEntityData;
		public override string DisplayName => "IncomUIRankRewards";

		public IncomUIRankRewardsEntity(FrostySdk.Ebx.IncomUIRankRewardsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

