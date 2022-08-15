using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientFirstPartySubscriptionEntityData))]
	public class ClientFirstPartySubscriptionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientFirstPartySubscriptionEntityData>
	{
		public new FrostySdk.Ebx.ClientFirstPartySubscriptionEntityData Data => data as FrostySdk.Ebx.ClientFirstPartySubscriptionEntityData;
		public override string DisplayName => "ClientFirstPartySubscription";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientFirstPartySubscriptionEntity(FrostySdk.Ebx.ClientFirstPartySubscriptionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

