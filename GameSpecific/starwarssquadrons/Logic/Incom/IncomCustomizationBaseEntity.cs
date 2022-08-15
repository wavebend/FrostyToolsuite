using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCustomizationBaseEntityData))]
	public class IncomCustomizationBaseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomCustomizationBaseEntityData>
	{
		public new FrostySdk.Ebx.IncomCustomizationBaseEntityData Data => data as FrostySdk.Ebx.IncomCustomizationBaseEntityData;
		public override string DisplayName => "IncomCustomizationBase";

		public IncomCustomizationBaseEntity(FrostySdk.Ebx.IncomCustomizationBaseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

