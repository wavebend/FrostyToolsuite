using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WorldIconsWidgetData))]
	public class WorldIconsWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.WorldIconsWidgetData>
	{
		public new FrostySdk.Ebx.WorldIconsWidgetData Data => data as FrostySdk.Ebx.WorldIconsWidgetData;
		public override string DisplayName => "WorldIconsWidget";

		public WorldIconsWidget(FrostySdk.Ebx.WorldIconsWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

