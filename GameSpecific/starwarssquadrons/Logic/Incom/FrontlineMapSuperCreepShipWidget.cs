using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapSuperCreepShipWidgetData))]
	public class FrontlineMapSuperCreepShipWidget : FrontlineMapShipWidget, IEntityData<FrostySdk.Ebx.FrontlineMapSuperCreepShipWidgetData>
	{
		public new FrostySdk.Ebx.FrontlineMapSuperCreepShipWidgetData Data => data as FrostySdk.Ebx.FrontlineMapSuperCreepShipWidgetData;
		public override string DisplayName => "FrontlineMapSuperCreepShipWidget";

		public FrontlineMapSuperCreepShipWidget(FrostySdk.Ebx.FrontlineMapSuperCreepShipWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

