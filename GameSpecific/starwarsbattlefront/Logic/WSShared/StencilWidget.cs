using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StencilWidgetData))]
	public class StencilWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.StencilWidgetData>
	{
		public new FrostySdk.Ebx.StencilWidgetData Data => data as FrostySdk.Ebx.StencilWidgetData;
		public override string DisplayName => "StencilWidget";

		public StencilWidget(FrostySdk.Ebx.StencilWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

