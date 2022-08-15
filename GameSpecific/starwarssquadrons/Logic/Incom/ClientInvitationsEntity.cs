using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientInvitationsEntityData))]
	public class ClientInvitationsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientInvitationsEntityData>
	{
		public new FrostySdk.Ebx.ClientInvitationsEntityData Data => data as FrostySdk.Ebx.ClientInvitationsEntityData;
		public override string DisplayName => "ClientInvitations";

		public ClientInvitationsEntity(FrostySdk.Ebx.ClientInvitationsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

