using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WatermarkWidgetData))]
	public class WatermarkWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.WatermarkWidgetData>
	{
		public new FrostySdk.Ebx.WatermarkWidgetData Data => data as FrostySdk.Ebx.WatermarkWidgetData;
		public override string DisplayName => "WatermarkWidget";

		public WatermarkWidget(FrostySdk.Ebx.WatermarkWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

