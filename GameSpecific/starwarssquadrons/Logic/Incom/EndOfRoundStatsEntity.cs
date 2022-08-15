using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EndOfRoundStatsEntityData))]
	public class EndOfRoundStatsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EndOfRoundStatsEntityData>
	{
		public new FrostySdk.Ebx.EndOfRoundStatsEntityData Data => data as FrostySdk.Ebx.EndOfRoundStatsEntityData;
		public override string DisplayName => "EndOfRoundStats";

		public EndOfRoundStatsEntity(FrostySdk.Ebx.EndOfRoundStatsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

