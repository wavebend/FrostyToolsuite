using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FocusableWidgetData))]
	public class FocusableWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.FocusableWidgetData>
	{
		public new FrostySdk.Ebx.FocusableWidgetData Data => data as FrostySdk.Ebx.FocusableWidgetData;
		public override string DisplayName => "FocusableWidget";

		public FocusableWidget(FrostySdk.Ebx.FocusableWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

