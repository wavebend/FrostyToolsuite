using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoftlockTargetHitPositionEntityData))]
	public class SoftlockTargetHitPositionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoftlockTargetHitPositionEntityData>
	{
		public new FrostySdk.Ebx.SoftlockTargetHitPositionEntityData Data => data as FrostySdk.Ebx.SoftlockTargetHitPositionEntityData;
		public override string DisplayName => "SoftlockTargetHitPosition";

		public SoftlockTargetHitPositionEntity(FrostySdk.Ebx.SoftlockTargetHitPositionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

