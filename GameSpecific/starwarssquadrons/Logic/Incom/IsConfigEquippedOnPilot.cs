using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IsConfigEquippedOnPilotData))]
	public class IsConfigEquippedOnPilot : LogicEntity, IEntityData<FrostySdk.Ebx.IsConfigEquippedOnPilotData>
	{
		public new FrostySdk.Ebx.IsConfigEquippedOnPilotData Data => data as FrostySdk.Ebx.IsConfigEquippedOnPilotData;
		public override string DisplayName => "IsConfigEquippedOnPilot";

		public IsConfigEquippedOnPilot(FrostySdk.Ebx.IsConfigEquippedOnPilotData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

