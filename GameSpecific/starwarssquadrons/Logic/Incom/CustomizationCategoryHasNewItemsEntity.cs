using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomizationCategoryHasNewItemsEntityData))]
	public class CustomizationCategoryHasNewItemsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomizationCategoryHasNewItemsEntityData>
	{
		public new FrostySdk.Ebx.CustomizationCategoryHasNewItemsEntityData Data => data as FrostySdk.Ebx.CustomizationCategoryHasNewItemsEntityData;
		public override string DisplayName => "CustomizationCategoryHasNewItems";

		public CustomizationCategoryHasNewItemsEntity(FrostySdk.Ebx.CustomizationCategoryHasNewItemsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

