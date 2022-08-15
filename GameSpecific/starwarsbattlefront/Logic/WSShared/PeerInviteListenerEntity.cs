using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PeerInviteListenerEntityData))]
	public class PeerInviteListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PeerInviteListenerEntityData>
	{
		public new FrostySdk.Ebx.PeerInviteListenerEntityData Data => data as FrostySdk.Ebx.PeerInviteListenerEntityData;
		public override string DisplayName => "PeerInviteListener";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PeerInviteListenerEntity(FrostySdk.Ebx.PeerInviteListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

