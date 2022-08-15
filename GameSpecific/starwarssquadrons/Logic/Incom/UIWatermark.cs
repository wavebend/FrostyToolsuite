using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIWatermarkData))]
	public class UIWatermark : LogicEntity, IEntityData<FrostySdk.Ebx.UIWatermarkData>
	{
		public new FrostySdk.Ebx.UIWatermarkData Data => data as FrostySdk.Ebx.UIWatermarkData;
		public override string DisplayName => "UIWatermark";

		public UIWatermark(FrostySdk.Ebx.UIWatermarkData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

