using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AchievementEntityData))]
	public class AchievementEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AchievementEntityData>
	{
		public new FrostySdk.Ebx.AchievementEntityData Data => data as FrostySdk.Ebx.AchievementEntityData;
		public override string DisplayName => "Achievement";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AchievementEntity(FrostySdk.Ebx.AchievementEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

