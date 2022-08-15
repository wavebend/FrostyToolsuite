using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BlurredBackgroundLevelsEntityData))]
	public class BlurredBackgroundLevelsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BlurredBackgroundLevelsEntityData>
	{
		public new FrostySdk.Ebx.BlurredBackgroundLevelsEntityData Data => data as FrostySdk.Ebx.BlurredBackgroundLevelsEntityData;
		public override string DisplayName => "BlurredBackgroundLevels";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public BlurredBackgroundLevelsEntity(FrostySdk.Ebx.BlurredBackgroundLevelsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

