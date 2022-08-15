using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectiveDisplayWidgetData))]
	public class ObjectiveDisplayWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.ObjectiveDisplayWidgetData>
	{
		public new FrostySdk.Ebx.ObjectiveDisplayWidgetData Data => data as FrostySdk.Ebx.ObjectiveDisplayWidgetData;
		public override string DisplayName => "ObjectiveDisplayWidget";

		public ObjectiveDisplayWidget(FrostySdk.Ebx.ObjectiveDisplayWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

