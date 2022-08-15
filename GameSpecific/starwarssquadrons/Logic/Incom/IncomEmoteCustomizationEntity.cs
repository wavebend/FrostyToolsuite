using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomEmoteCustomizationEntityData))]
	public class IncomEmoteCustomizationEntity : IncomCustomizationBaseEntity, IEntityData<FrostySdk.Ebx.IncomEmoteCustomizationEntityData>
	{
		public new FrostySdk.Ebx.IncomEmoteCustomizationEntityData Data => data as FrostySdk.Ebx.IncomEmoteCustomizationEntityData;
		public override string DisplayName => "IncomEmoteCustomization";

		public IncomEmoteCustomizationEntity(FrostySdk.Ebx.IncomEmoteCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

