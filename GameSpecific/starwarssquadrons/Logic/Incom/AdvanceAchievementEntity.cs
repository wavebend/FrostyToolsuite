using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AdvanceAchievementEntityData))]
	public class AdvanceAchievementEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AdvanceAchievementEntityData>
	{
		public new FrostySdk.Ebx.AdvanceAchievementEntityData Data => data as FrostySdk.Ebx.AdvanceAchievementEntityData;
		public override string DisplayName => "AdvanceAchievement";

		public AdvanceAchievementEntity(FrostySdk.Ebx.AdvanceAchievementEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

