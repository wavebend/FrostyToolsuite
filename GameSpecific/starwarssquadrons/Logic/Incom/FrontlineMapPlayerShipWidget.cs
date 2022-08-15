using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapPlayerShipWidgetData))]
	public class FrontlineMapPlayerShipWidget : FrontlineMapShipWidget, IEntityData<FrostySdk.Ebx.FrontlineMapPlayerShipWidgetData>
	{
		public new FrostySdk.Ebx.FrontlineMapPlayerShipWidgetData Data => data as FrostySdk.Ebx.FrontlineMapPlayerShipWidgetData;
		public override string DisplayName => "FrontlineMapPlayerShipWidget";

		public FrontlineMapPlayerShipWidget(FrostySdk.Ebx.FrontlineMapPlayerShipWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

