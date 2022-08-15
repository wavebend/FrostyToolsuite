using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientFirstPartyStoreOfferTileDataProviderData))]
	public class ClientFirstPartyStoreOfferTileDataProvider : LogicEntity, IEntityData<FrostySdk.Ebx.ClientFirstPartyStoreOfferTileDataProviderData>
	{
		public new FrostySdk.Ebx.ClientFirstPartyStoreOfferTileDataProviderData Data => data as FrostySdk.Ebx.ClientFirstPartyStoreOfferTileDataProviderData;
		public override string DisplayName => "ClientFirstPartyStoreOfferTileDataProvider";

		public ClientFirstPartyStoreOfferTileDataProvider(FrostySdk.Ebx.ClientFirstPartyStoreOfferTileDataProviderData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

