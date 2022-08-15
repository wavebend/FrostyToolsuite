using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoftLockPredictiveOffsetAISSVREntityData))]
	public class SoftLockPredictiveOffsetAISSVREntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoftLockPredictiveOffsetAISSVREntityData>
	{
		public new FrostySdk.Ebx.SoftLockPredictiveOffsetAISSVREntityData Data => data as FrostySdk.Ebx.SoftLockPredictiveOffsetAISSVREntityData;
		public override string DisplayName => "SoftLockPredictiveOffsetAISSVR";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SoftLockPredictiveOffsetAISSVREntity(FrostySdk.Ebx.SoftLockPredictiveOffsetAISSVREntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

