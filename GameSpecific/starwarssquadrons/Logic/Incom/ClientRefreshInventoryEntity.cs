using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientRefreshInventoryEntityData))]
	public class ClientRefreshInventoryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientRefreshInventoryEntityData>
	{
		public new FrostySdk.Ebx.ClientRefreshInventoryEntityData Data => data as FrostySdk.Ebx.ClientRefreshInventoryEntityData;
		public override string DisplayName => "ClientRefreshInventory";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientRefreshInventoryEntity(FrostySdk.Ebx.ClientRefreshInventoryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

