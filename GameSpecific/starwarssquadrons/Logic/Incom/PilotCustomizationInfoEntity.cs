using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PilotCustomizationInfoEntityData))]
	public class PilotCustomizationInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PilotCustomizationInfoEntityData>
	{
		public new FrostySdk.Ebx.PilotCustomizationInfoEntityData Data => data as FrostySdk.Ebx.PilotCustomizationInfoEntityData;
		public override string DisplayName => "PilotCustomizationInfo";

		public PilotCustomizationInfoEntity(FrostySdk.Ebx.PilotCustomizationInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

