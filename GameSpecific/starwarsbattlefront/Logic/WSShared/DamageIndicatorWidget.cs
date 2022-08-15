using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageIndicatorWidgetData))]
	public class DamageIndicatorWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.DamageIndicatorWidgetData>
	{
		public new FrostySdk.Ebx.DamageIndicatorWidgetData Data => data as FrostySdk.Ebx.DamageIndicatorWidgetData;
		public override string DisplayName => "DamageIndicatorWidget";

		public DamageIndicatorWidget(FrostySdk.Ebx.DamageIndicatorWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

