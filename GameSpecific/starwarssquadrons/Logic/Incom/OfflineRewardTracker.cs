using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OfflineRewardTrackerData))]
	public class OfflineRewardTracker : LogicEntity, IEntityData<FrostySdk.Ebx.OfflineRewardTrackerData>
	{
		public new FrostySdk.Ebx.OfflineRewardTrackerData Data => data as FrostySdk.Ebx.OfflineRewardTrackerData;
		public override string DisplayName => "OfflineRewardTracker";

		public OfflineRewardTracker(FrostySdk.Ebx.OfflineRewardTrackerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

