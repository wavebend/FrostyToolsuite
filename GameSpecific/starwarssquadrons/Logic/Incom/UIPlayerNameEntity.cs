using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPlayerNameEntityData))]
	public class UIPlayerNameEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIPlayerNameEntityData>
	{
		public new FrostySdk.Ebx.UIPlayerNameEntityData Data => data as FrostySdk.Ebx.UIPlayerNameEntityData;
		public override string DisplayName => "UIPlayerName";

		public UIPlayerNameEntity(FrostySdk.Ebx.UIPlayerNameEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

