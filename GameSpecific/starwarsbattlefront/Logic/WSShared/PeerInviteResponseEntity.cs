using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PeerInviteResponseEntityData))]
	public class PeerInviteResponseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PeerInviteResponseEntityData>
	{
		public new FrostySdk.Ebx.PeerInviteResponseEntityData Data => data as FrostySdk.Ebx.PeerInviteResponseEntityData;
		public override string DisplayName => "PeerInviteResponse";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PeerInviteResponseEntity(FrostySdk.Ebx.PeerInviteResponseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

