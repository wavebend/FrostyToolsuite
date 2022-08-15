using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UserConnectedEntityData))]
	public class UserConnectedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UserConnectedEntityData>
	{
		public new FrostySdk.Ebx.UserConnectedEntityData Data => data as FrostySdk.Ebx.UserConnectedEntityData;
		public override string DisplayName => "UserConnected";

		public UserConnectedEntity(FrostySdk.Ebx.UserConnectedEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

