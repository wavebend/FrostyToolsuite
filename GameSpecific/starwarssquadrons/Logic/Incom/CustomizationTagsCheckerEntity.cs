using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomizationTagsCheckerEntityData))]
	public class CustomizationTagsCheckerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomizationTagsCheckerEntityData>
	{
		public new FrostySdk.Ebx.CustomizationTagsCheckerEntityData Data => data as FrostySdk.Ebx.CustomizationTagsCheckerEntityData;
		public override string DisplayName => "CustomizationTagsChecker";

		public CustomizationTagsCheckerEntity(FrostySdk.Ebx.CustomizationTagsCheckerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

