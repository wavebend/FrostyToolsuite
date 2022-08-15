using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretTargetComputerSettingsEntityData))]
	public class TurretTargetComputerSettingsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TurretTargetComputerSettingsEntityData>
	{
		public new FrostySdk.Ebx.TurretTargetComputerSettingsEntityData Data => data as FrostySdk.Ebx.TurretTargetComputerSettingsEntityData;
		public override string DisplayName => "TurretTargetComputerSettings";

		public TurretTargetComputerSettingsEntity(FrostySdk.Ebx.TurretTargetComputerSettingsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

