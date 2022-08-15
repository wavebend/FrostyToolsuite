using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPlayerInfoEntityData))]
	public class UIPlayerInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIPlayerInfoEntityData>
	{
		public new FrostySdk.Ebx.UIPlayerInfoEntityData Data => data as FrostySdk.Ebx.UIPlayerInfoEntityData;
		public override string DisplayName => "UIPlayerInfo";

		public UIPlayerInfoEntity(FrostySdk.Ebx.UIPlayerInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

