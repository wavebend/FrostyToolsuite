using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPilotCustomizationEntityData))]
	public class IncomPilotCustomizationEntity : IncomCustomizationBaseEntity, IEntityData<FrostySdk.Ebx.IncomPilotCustomizationEntityData>
	{
		public new FrostySdk.Ebx.IncomPilotCustomizationEntityData Data => data as FrostySdk.Ebx.IncomPilotCustomizationEntityData;
		public override string DisplayName => "IncomPilotCustomization";

		public IncomPilotCustomizationEntity(FrostySdk.Ebx.IncomPilotCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

