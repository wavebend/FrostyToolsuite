using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineHealthPickupWidgetData))]
	public class FrontlineHealthPickupWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.FrontlineHealthPickupWidgetData>
	{
		public new FrostySdk.Ebx.FrontlineHealthPickupWidgetData Data => data as FrostySdk.Ebx.FrontlineHealthPickupWidgetData;
		public override string DisplayName => "FrontlineHealthPickupWidget";

		public FrontlineHealthPickupWidget(FrostySdk.Ebx.FrontlineHealthPickupWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

