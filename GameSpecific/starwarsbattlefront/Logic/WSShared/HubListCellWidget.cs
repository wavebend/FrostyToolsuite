using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubListCellWidgetData))]
	public class HubListCellWidget : ListCellWidget, IEntityData<FrostySdk.Ebx.HubListCellWidgetData>
	{
		public new FrostySdk.Ebx.HubListCellWidgetData Data => data as FrostySdk.Ebx.HubListCellWidgetData;
		public override string DisplayName => "HubListCellWidget";

		public HubListCellWidget(FrostySdk.Ebx.HubListCellWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

