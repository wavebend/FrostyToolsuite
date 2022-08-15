using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerInputRestrictionExEntityData))]
	public class PlayerInputRestrictionExEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerInputRestrictionExEntityData>
	{
		public new FrostySdk.Ebx.PlayerInputRestrictionExEntityData Data => data as FrostySdk.Ebx.PlayerInputRestrictionExEntityData;
		public override string DisplayName => "PlayerInputRestrictionEx";

		public PlayerInputRestrictionExEntity(FrostySdk.Ebx.PlayerInputRestrictionExEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

