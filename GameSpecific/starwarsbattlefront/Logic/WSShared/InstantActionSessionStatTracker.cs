using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InstantActionSessionStatTrackerData))]
	public class InstantActionSessionStatTracker : LogicEntity, IEntityData<FrostySdk.Ebx.InstantActionSessionStatTrackerData>
	{
		public new FrostySdk.Ebx.InstantActionSessionStatTrackerData Data => data as FrostySdk.Ebx.InstantActionSessionStatTrackerData;
		public override string DisplayName => "InstantActionSessionStatTracker";

		public InstantActionSessionStatTracker(FrostySdk.Ebx.InstantActionSessionStatTrackerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

