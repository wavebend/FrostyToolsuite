using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PerformanceDebuggingWidgetData))]
	public class PerformanceDebuggingWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.PerformanceDebuggingWidgetData>
	{
		public new FrostySdk.Ebx.PerformanceDebuggingWidgetData Data => data as FrostySdk.Ebx.PerformanceDebuggingWidgetData;
		public override string DisplayName => "PerformanceDebuggingWidget";

		public PerformanceDebuggingWidget(FrostySdk.Ebx.PerformanceDebuggingWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

