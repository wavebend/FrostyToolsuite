using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlinePingWidgetData))]
	public class FrontlinePingWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.FrontlinePingWidgetData>
	{
		public new FrostySdk.Ebx.FrontlinePingWidgetData Data => data as FrostySdk.Ebx.FrontlinePingWidgetData;
		public override string DisplayName => "FrontlinePingWidget";

		public FrontlinePingWidget(FrostySdk.Ebx.FrontlinePingWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

