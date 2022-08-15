using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CheckOfflineInvitesEntityData))]
	public class CheckOfflineInvitesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CheckOfflineInvitesEntityData>
	{
		public new FrostySdk.Ebx.CheckOfflineInvitesEntityData Data => data as FrostySdk.Ebx.CheckOfflineInvitesEntityData;
		public override string DisplayName => "CheckOfflineInvites";

		public CheckOfflineInvitesEntity(FrostySdk.Ebx.CheckOfflineInvitesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

