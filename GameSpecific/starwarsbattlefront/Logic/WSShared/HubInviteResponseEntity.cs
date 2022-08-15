using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubInviteResponseEntityData))]
	public class HubInviteResponseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubInviteResponseEntityData>
	{
		public new FrostySdk.Ebx.HubInviteResponseEntityData Data => data as FrostySdk.Ebx.HubInviteResponseEntityData;
		public override string DisplayName => "HubInviteResponse";

		public HubInviteResponseEntity(FrostySdk.Ebx.HubInviteResponseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

