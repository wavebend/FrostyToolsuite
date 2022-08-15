using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientOnlineStatusEntityData))]
	public class ClientOnlineStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientOnlineStatusEntityData>
	{
		public new FrostySdk.Ebx.ClientOnlineStatusEntityData Data => data as FrostySdk.Ebx.ClientOnlineStatusEntityData;
		public override string DisplayName => "ClientOnlineStatus";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientOnlineStatusEntity(FrostySdk.Ebx.ClientOnlineStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

