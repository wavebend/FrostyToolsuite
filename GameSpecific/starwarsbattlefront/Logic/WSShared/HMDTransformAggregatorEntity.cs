using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HMDTransformAggregatorEntityData))]
	public class HMDTransformAggregatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HMDTransformAggregatorEntityData>
	{
		public new FrostySdk.Ebx.HMDTransformAggregatorEntityData Data => data as FrostySdk.Ebx.HMDTransformAggregatorEntityData;
		public override string DisplayName => "HMDTransformAggregator";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HMDTransformAggregatorEntity(FrostySdk.Ebx.HMDTransformAggregatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

