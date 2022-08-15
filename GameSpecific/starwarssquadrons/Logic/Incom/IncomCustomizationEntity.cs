using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCustomizationEntityData))]
	public class IncomCustomizationEntity : IncomCustomizationBaseEntity, IEntityData<FrostySdk.Ebx.IncomCustomizationEntityData>
	{
		public new FrostySdk.Ebx.IncomCustomizationEntityData Data => data as FrostySdk.Ebx.IncomCustomizationEntityData;
		public override string DisplayName => "IncomCustomization";

		public IncomCustomizationEntity(FrostySdk.Ebx.IncomCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

