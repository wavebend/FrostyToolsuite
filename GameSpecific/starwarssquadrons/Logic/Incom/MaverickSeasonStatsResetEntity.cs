using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaverickSeasonStatsResetEntityData))]
	public class MaverickSeasonStatsResetEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MaverickSeasonStatsResetEntityData>
	{
		public new FrostySdk.Ebx.MaverickSeasonStatsResetEntityData Data => data as FrostySdk.Ebx.MaverickSeasonStatsResetEntityData;
		public override string DisplayName => "MaverickSeasonStatsReset";

		public MaverickSeasonStatsResetEntity(FrostySdk.Ebx.MaverickSeasonStatsResetEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

