using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FocusDrawingWidgetData))]
	public class FocusDrawingWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.FocusDrawingWidgetData>
	{
		public new FrostySdk.Ebx.FocusDrawingWidgetData Data => data as FrostySdk.Ebx.FocusDrawingWidgetData;
		public override string DisplayName => "FocusDrawingWidget";

		public FocusDrawingWidget(FrostySdk.Ebx.FocusDrawingWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

