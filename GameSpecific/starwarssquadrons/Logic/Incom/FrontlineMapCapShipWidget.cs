using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapCapShipWidgetData))]
	public class FrontlineMapCapShipWidget : FrontlineMapShipWidget, IEntityData<FrostySdk.Ebx.FrontlineMapCapShipWidgetData>
	{
		public new FrostySdk.Ebx.FrontlineMapCapShipWidgetData Data => data as FrostySdk.Ebx.FrontlineMapCapShipWidgetData;
		public override string DisplayName => "FrontlineMapCapShipWidget";

		public FrontlineMapCapShipWidget(FrostySdk.Ebx.FrontlineMapCapShipWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

