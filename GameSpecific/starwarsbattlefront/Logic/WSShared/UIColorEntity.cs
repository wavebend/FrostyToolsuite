using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIColorEntityData))]
	public class UIColorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIColorEntityData>
	{
		public new FrostySdk.Ebx.UIColorEntityData Data => data as FrostySdk.Ebx.UIColorEntityData;
		public override string DisplayName => "UIColor";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UIColorEntity(FrostySdk.Ebx.UIColorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

