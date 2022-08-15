using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVehicleCollisionAvoidanceEntityData))]
	public class WSVehicleCollisionAvoidanceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WSVehicleCollisionAvoidanceEntityData>
	{
		public new FrostySdk.Ebx.WSVehicleCollisionAvoidanceEntityData Data => data as FrostySdk.Ebx.WSVehicleCollisionAvoidanceEntityData;
		public override string DisplayName => "WSVehicleCollisionAvoidance";

		public WSVehicleCollisionAvoidanceEntity(FrostySdk.Ebx.WSVehicleCollisionAvoidanceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

