using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchKickPlayerEntityData))]
	public class CustomMatchKickPlayerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchKickPlayerEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchKickPlayerEntityData Data => data as FrostySdk.Ebx.CustomMatchKickPlayerEntityData;
		public override string DisplayName => "CustomMatchKickPlayer";

		public CustomMatchKickPlayerEntity(FrostySdk.Ebx.CustomMatchKickPlayerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

