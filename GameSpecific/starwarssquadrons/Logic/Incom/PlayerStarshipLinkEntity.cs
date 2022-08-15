using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerStarshipLinkEntityData))]
	public class PlayerStarshipLinkEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerStarshipLinkEntityData>
	{
		public new FrostySdk.Ebx.PlayerStarshipLinkEntityData Data => data as FrostySdk.Ebx.PlayerStarshipLinkEntityData;
		public override string DisplayName => "PlayerStarshipLink";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerStarshipLinkEntity(FrostySdk.Ebx.PlayerStarshipLinkEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

