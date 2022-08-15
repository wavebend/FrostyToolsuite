using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StackLayoutWidgetData))]
	public class StackLayoutWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.StackLayoutWidgetData>
	{
		public new FrostySdk.Ebx.StackLayoutWidgetData Data => data as FrostySdk.Ebx.StackLayoutWidgetData;
		public override string DisplayName => "StackLayoutWidget";

		public StackLayoutWidget(FrostySdk.Ebx.StackLayoutWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

