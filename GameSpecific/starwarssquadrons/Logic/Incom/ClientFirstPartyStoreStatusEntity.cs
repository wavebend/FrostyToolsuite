using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientFirstPartyStoreStatusEntityData))]
	public class ClientFirstPartyStoreStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientFirstPartyStoreStatusEntityData>
	{
		public new FrostySdk.Ebx.ClientFirstPartyStoreStatusEntityData Data => data as FrostySdk.Ebx.ClientFirstPartyStoreStatusEntityData;
		public override string DisplayName => "ClientFirstPartyStoreStatus";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientFirstPartyStoreStatusEntity(FrostySdk.Ebx.ClientFirstPartyStoreStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

