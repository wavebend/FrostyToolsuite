using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIWorldScaleEntityData))]
	public class UIWorldScaleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIWorldScaleEntityData>
	{
		public new FrostySdk.Ebx.UIWorldScaleEntityData Data => data as FrostySdk.Ebx.UIWorldScaleEntityData;
		public override string DisplayName => "UIWorldScale";

		public UIWorldScaleEntity(FrostySdk.Ebx.UIWorldScaleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

