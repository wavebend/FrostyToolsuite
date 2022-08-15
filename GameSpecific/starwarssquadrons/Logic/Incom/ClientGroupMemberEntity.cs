using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientGroupMemberEntityData))]
	public class ClientGroupMemberEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientGroupMemberEntityData>
	{
		public new FrostySdk.Ebx.ClientGroupMemberEntityData Data => data as FrostySdk.Ebx.ClientGroupMemberEntityData;
		public override string DisplayName => "ClientGroupMember";

		public ClientGroupMemberEntity(FrostySdk.Ebx.ClientGroupMemberEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

