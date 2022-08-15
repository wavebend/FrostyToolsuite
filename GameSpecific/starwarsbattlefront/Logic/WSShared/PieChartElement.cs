using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PieChartElementData))]
	public class PieChartElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.PieChartElementData>
	{
		public new FrostySdk.Ebx.PieChartElementData Data => data as FrostySdk.Ebx.PieChartElementData;
		public override string DisplayName => "PieChartElement";

		public PieChartElement(FrostySdk.Ebx.PieChartElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

