using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontendStatsEntityData))]
	public class FrontendStatsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontendStatsEntityData>
	{
		public new FrostySdk.Ebx.FrontendStatsEntityData Data => data as FrostySdk.Ebx.FrontendStatsEntityData;
		public override string DisplayName => "FrontendStats";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public FrontendStatsEntity(FrostySdk.Ebx.FrontendStatsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

