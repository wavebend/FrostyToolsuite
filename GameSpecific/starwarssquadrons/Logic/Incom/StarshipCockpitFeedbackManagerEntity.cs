using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipCockpitFeedbackManagerEntityData))]
	public class StarshipCockpitFeedbackManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipCockpitFeedbackManagerEntityData>
	{
		public new FrostySdk.Ebx.StarshipCockpitFeedbackManagerEntityData Data => data as FrostySdk.Ebx.StarshipCockpitFeedbackManagerEntityData;
		public override string DisplayName => "StarshipCockpitFeedbackManager";

		public StarshipCockpitFeedbackManagerEntity(FrostySdk.Ebx.StarshipCockpitFeedbackManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

