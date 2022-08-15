using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LoadoutCustomizationEntityData))]
	public class LoadoutCustomizationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LoadoutCustomizationEntityData>
	{
		public new FrostySdk.Ebx.LoadoutCustomizationEntityData Data => data as FrostySdk.Ebx.LoadoutCustomizationEntityData;
		public override string DisplayName => "LoadoutCustomization";

		public LoadoutCustomizationEntity(FrostySdk.Ebx.LoadoutCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

