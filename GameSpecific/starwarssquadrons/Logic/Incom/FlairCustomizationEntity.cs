using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FlairCustomizationEntityData))]
	public class FlairCustomizationEntity : IncomCustomizationBaseEntity, IEntityData<FrostySdk.Ebx.FlairCustomizationEntityData>
	{
		public new FrostySdk.Ebx.FlairCustomizationEntityData Data => data as FrostySdk.Ebx.FlairCustomizationEntityData;
		public override string DisplayName => "FlairCustomization";

		public FlairCustomizationEntity(FrostySdk.Ebx.FlairCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

