using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PopupScreenWidgetData))]
	public class PopupScreenWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.PopupScreenWidgetData>
	{
		public new FrostySdk.Ebx.PopupScreenWidgetData Data => data as FrostySdk.Ebx.PopupScreenWidgetData;
		public override string DisplayName => "PopupScreenWidget";

		public PopupScreenWidget(FrostySdk.Ebx.PopupScreenWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

