using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerOnlineInfoEntityData))]
	public class PlayerOnlineInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerOnlineInfoEntityData>
	{
		public new FrostySdk.Ebx.PlayerOnlineInfoEntityData Data => data as FrostySdk.Ebx.PlayerOnlineInfoEntityData;
		public override string DisplayName => "PlayerOnlineInfo";

		public PlayerOnlineInfoEntity(FrostySdk.Ebx.PlayerOnlineInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

