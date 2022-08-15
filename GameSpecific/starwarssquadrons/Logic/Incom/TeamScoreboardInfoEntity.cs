using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TeamScoreboardInfoEntityData))]
	public class TeamScoreboardInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TeamScoreboardInfoEntityData>
	{
		public new FrostySdk.Ebx.TeamScoreboardInfoEntityData Data => data as FrostySdk.Ebx.TeamScoreboardInfoEntityData;
		public override string DisplayName => "TeamScoreboardInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public TeamScoreboardInfoEntity(FrostySdk.Ebx.TeamScoreboardInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

