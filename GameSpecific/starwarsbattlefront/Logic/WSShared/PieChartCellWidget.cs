using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PieChartCellWidgetData))]
	public class PieChartCellWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.PieChartCellWidgetData>
	{
		public new FrostySdk.Ebx.PieChartCellWidgetData Data => data as FrostySdk.Ebx.PieChartCellWidgetData;
		public override string DisplayName => "PieChartCellWidget";

		public PieChartCellWidget(FrostySdk.Ebx.PieChartCellWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

