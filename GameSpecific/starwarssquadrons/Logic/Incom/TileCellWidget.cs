using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TileCellWidgetData))]
	public class TileCellWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.TileCellWidgetData>
	{
		public new FrostySdk.Ebx.TileCellWidgetData Data => data as FrostySdk.Ebx.TileCellWidgetData;
		public override string DisplayName => "TileCellWidget";

		public TileCellWidget(FrostySdk.Ebx.TileCellWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

