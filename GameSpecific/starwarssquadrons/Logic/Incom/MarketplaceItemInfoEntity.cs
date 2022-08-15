using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MarketplaceItemInfoEntityData))]
	public class MarketplaceItemInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MarketplaceItemInfoEntityData>
	{
		public new FrostySdk.Ebx.MarketplaceItemInfoEntityData Data => data as FrostySdk.Ebx.MarketplaceItemInfoEntityData;
		public override string DisplayName => "MarketplaceItemInfo";

		public MarketplaceItemInfoEntity(FrostySdk.Ebx.MarketplaceItemInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

