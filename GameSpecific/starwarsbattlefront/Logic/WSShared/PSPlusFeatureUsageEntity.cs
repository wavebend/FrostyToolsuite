using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PSPlusFeatureUsageEntityData))]
	public class PSPlusFeatureUsageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PSPlusFeatureUsageEntityData>
	{
		public new FrostySdk.Ebx.PSPlusFeatureUsageEntityData Data => data as FrostySdk.Ebx.PSPlusFeatureUsageEntityData;
		public override string DisplayName => "PSPlusFeatureUsage";

		public PSPlusFeatureUsageEntity(FrostySdk.Ebx.PSPlusFeatureUsageEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

