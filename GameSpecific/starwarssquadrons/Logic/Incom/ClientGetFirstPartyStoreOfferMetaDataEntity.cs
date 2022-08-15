using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientGetFirstPartyStoreOfferMetaDataEntityData))]
	public class ClientGetFirstPartyStoreOfferMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientGetFirstPartyStoreOfferMetaDataEntityData>
	{
		public new FrostySdk.Ebx.ClientGetFirstPartyStoreOfferMetaDataEntityData Data => data as FrostySdk.Ebx.ClientGetFirstPartyStoreOfferMetaDataEntityData;
		public override string DisplayName => "ClientGetFirstPartyStoreOfferMetaData";

		public ClientGetFirstPartyStoreOfferMetaDataEntity(FrostySdk.Ebx.ClientGetFirstPartyStoreOfferMetaDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

