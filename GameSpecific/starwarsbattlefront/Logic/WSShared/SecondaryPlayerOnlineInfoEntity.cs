using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SecondaryPlayerOnlineInfoEntityData))]
	public class SecondaryPlayerOnlineInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SecondaryPlayerOnlineInfoEntityData>
	{
		public new FrostySdk.Ebx.SecondaryPlayerOnlineInfoEntityData Data => data as FrostySdk.Ebx.SecondaryPlayerOnlineInfoEntityData;
		public override string DisplayName => "SecondaryPlayerOnlineInfo";

		public SecondaryPlayerOnlineInfoEntity(FrostySdk.Ebx.SecondaryPlayerOnlineInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

