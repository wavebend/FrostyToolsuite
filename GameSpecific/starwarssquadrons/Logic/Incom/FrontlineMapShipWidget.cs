using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapShipWidgetData))]
	public class FrontlineMapShipWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.FrontlineMapShipWidgetData>
	{
		public new FrostySdk.Ebx.FrontlineMapShipWidgetData Data => data as FrostySdk.Ebx.FrontlineMapShipWidgetData;
		public override string DisplayName => "FrontlineMapShipWidget";

		public FrontlineMapShipWidget(FrostySdk.Ebx.FrontlineMapShipWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

