using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DrawcallBatchingWidgetData))]
	public class DrawcallBatchingWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.DrawcallBatchingWidgetData>
	{
		public new FrostySdk.Ebx.DrawcallBatchingWidgetData Data => data as FrostySdk.Ebx.DrawcallBatchingWidgetData;
		public override string DisplayName => "DrawcallBatchingWidget";

		public DrawcallBatchingWidget(FrostySdk.Ebx.DrawcallBatchingWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

