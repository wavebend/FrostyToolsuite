using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AppearanceCustomizationEntityData))]
	public class AppearanceCustomizationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AppearanceCustomizationEntityData>
	{
		public new FrostySdk.Ebx.AppearanceCustomizationEntityData Data => data as FrostySdk.Ebx.AppearanceCustomizationEntityData;
		public override string DisplayName => "AppearanceCustomization";

		public AppearanceCustomizationEntity(FrostySdk.Ebx.AppearanceCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

