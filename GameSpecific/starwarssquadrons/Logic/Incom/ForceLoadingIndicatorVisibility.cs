using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceLoadingIndicatorVisibilityData))]
	public class ForceLoadingIndicatorVisibility : LogicEntity, IEntityData<FrostySdk.Ebx.ForceLoadingIndicatorVisibilityData>
	{
		public new FrostySdk.Ebx.ForceLoadingIndicatorVisibilityData Data => data as FrostySdk.Ebx.ForceLoadingIndicatorVisibilityData;
		public override string DisplayName => "ForceLoadingIndicatorVisibility";

		public ForceLoadingIndicatorVisibility(FrostySdk.Ebx.ForceLoadingIndicatorVisibilityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

