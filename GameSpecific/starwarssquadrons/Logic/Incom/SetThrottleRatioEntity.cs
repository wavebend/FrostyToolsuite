using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SetThrottleRatioEntityData))]
	public class SetThrottleRatioEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SetThrottleRatioEntityData>
	{
		public new FrostySdk.Ebx.SetThrottleRatioEntityData Data => data as FrostySdk.Ebx.SetThrottleRatioEntityData;
		public override string DisplayName => "SetThrottleRatio";

		public SetThrottleRatioEntity(FrostySdk.Ebx.SetThrottleRatioEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

