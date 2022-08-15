using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MarketplaceBundleItemInfoEntityData))]
	public class MarketplaceBundleItemInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MarketplaceBundleItemInfoEntityData>
	{
		public new FrostySdk.Ebx.MarketplaceBundleItemInfoEntityData Data => data as FrostySdk.Ebx.MarketplaceBundleItemInfoEntityData;
		public override string DisplayName => "MarketplaceBundleItemInfo";

		public MarketplaceBundleItemInfoEntity(FrostySdk.Ebx.MarketplaceBundleItemInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

