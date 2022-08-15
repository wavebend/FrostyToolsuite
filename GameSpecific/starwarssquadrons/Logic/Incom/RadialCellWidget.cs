using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadialCellWidgetData))]
	public class RadialCellWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.RadialCellWidgetData>
	{
		public new FrostySdk.Ebx.RadialCellWidgetData Data => data as FrostySdk.Ebx.RadialCellWidgetData;
		public override string DisplayName => "RadialCellWidget";

		public RadialCellWidget(FrostySdk.Ebx.RadialCellWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

