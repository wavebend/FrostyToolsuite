using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubInvitesEntityData))]
	public class HubInvitesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubInvitesEntityData>
	{
		public new FrostySdk.Ebx.HubInvitesEntityData Data => data as FrostySdk.Ebx.HubInvitesEntityData;
		public override string DisplayName => "HubInvites";

		public HubInvitesEntity(FrostySdk.Ebx.HubInvitesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

