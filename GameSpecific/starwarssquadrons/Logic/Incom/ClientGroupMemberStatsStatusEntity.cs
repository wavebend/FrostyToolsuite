using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientGroupMemberStatsStatusEntityData))]
	public class ClientGroupMemberStatsStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientGroupMemberStatsStatusEntityData>
	{
		public new FrostySdk.Ebx.ClientGroupMemberStatsStatusEntityData Data => data as FrostySdk.Ebx.ClientGroupMemberStatsStatusEntityData;
		public override string DisplayName => "ClientGroupMemberStatsStatus";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientGroupMemberStatsStatusEntity(FrostySdk.Ebx.ClientGroupMemberStatsStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

