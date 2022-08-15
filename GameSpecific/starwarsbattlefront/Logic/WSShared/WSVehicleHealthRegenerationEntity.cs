using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVehicleHealthRegenerationEntityData))]
	public class WSVehicleHealthRegenerationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WSVehicleHealthRegenerationEntityData>
	{
		public new FrostySdk.Ebx.WSVehicleHealthRegenerationEntityData Data => data as FrostySdk.Ebx.WSVehicleHealthRegenerationEntityData;
		public override string DisplayName => "WSVehicleHealthRegeneration";

		public WSVehicleHealthRegenerationEntity(FrostySdk.Ebx.WSVehicleHealthRegenerationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

