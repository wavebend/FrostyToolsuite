using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipCockpitMotionFeedbackEntityData))]
	public class StarshipCockpitMotionFeedbackEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipCockpitMotionFeedbackEntityData>
	{
		public new FrostySdk.Ebx.StarshipCockpitMotionFeedbackEntityData Data => data as FrostySdk.Ebx.StarshipCockpitMotionFeedbackEntityData;
		public override string DisplayName => "StarshipCockpitMotionFeedback";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public StarshipCockpitMotionFeedbackEntity(FrostySdk.Ebx.StarshipCockpitMotionFeedbackEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

