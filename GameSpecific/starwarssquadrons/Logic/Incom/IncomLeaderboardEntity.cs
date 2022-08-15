using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomLeaderboardEntityData))]
	public class IncomLeaderboardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomLeaderboardEntityData>
	{
		public new FrostySdk.Ebx.IncomLeaderboardEntityData Data => data as FrostySdk.Ebx.IncomLeaderboardEntityData;
		public override string DisplayName => "IncomLeaderboard";

		public IncomLeaderboardEntity(FrostySdk.Ebx.IncomLeaderboardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

