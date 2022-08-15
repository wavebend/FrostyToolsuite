using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MatchmakingProgressInfoEntityData))]
	public class MatchmakingProgressInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MatchmakingProgressInfoEntityData>
	{
		public new FrostySdk.Ebx.MatchmakingProgressInfoEntityData Data => data as FrostySdk.Ebx.MatchmakingProgressInfoEntityData;
		public override string DisplayName => "MatchmakingProgressInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public MatchmakingProgressInfoEntity(FrostySdk.Ebx.MatchmakingProgressInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

