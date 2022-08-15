using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaverickStatsEntityData))]
	public class MaverickStatsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MaverickStatsEntityData>
	{
		public new FrostySdk.Ebx.MaverickStatsEntityData Data => data as FrostySdk.Ebx.MaverickStatsEntityData;
		public override string DisplayName => "MaverickStats";

		public MaverickStatsEntity(FrostySdk.Ebx.MaverickStatsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

