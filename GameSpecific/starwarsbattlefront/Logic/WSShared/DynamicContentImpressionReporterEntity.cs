using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DynamicContentImpressionReporterEntityData))]
	public class DynamicContentImpressionReporterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DynamicContentImpressionReporterEntityData>
	{
		public new FrostySdk.Ebx.DynamicContentImpressionReporterEntityData Data => data as FrostySdk.Ebx.DynamicContentImpressionReporterEntityData;
		public override string DisplayName => "DynamicContentImpressionReporter";

		public DynamicContentImpressionReporterEntity(FrostySdk.Ebx.DynamicContentImpressionReporterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

