using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerAccountInfoEntityData))]
	public class PlayerAccountInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerAccountInfoEntityData>
	{
		public new FrostySdk.Ebx.PlayerAccountInfoEntityData Data => data as FrostySdk.Ebx.PlayerAccountInfoEntityData;
		public override string DisplayName => "PlayerAccountInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerAccountInfoEntity(FrostySdk.Ebx.PlayerAccountInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

