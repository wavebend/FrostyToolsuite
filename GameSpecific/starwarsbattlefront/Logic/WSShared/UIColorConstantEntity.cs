using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIColorConstantEntityData))]
	public class UIColorConstantEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIColorConstantEntityData>
	{
		public new FrostySdk.Ebx.UIColorConstantEntityData Data => data as FrostySdk.Ebx.UIColorConstantEntityData;
		public override string DisplayName => "UIColorConstant";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UIColorConstantEntity(FrostySdk.Ebx.UIColorConstantEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

