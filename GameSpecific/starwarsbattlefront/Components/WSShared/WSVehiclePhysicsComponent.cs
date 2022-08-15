
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVehiclePhysicsComponentData))]
	public class WSVehiclePhysicsComponent : VehiclePhysicsComponent, IEntityData<FrostySdk.Ebx.WSVehiclePhysicsComponentData>
	{
		public new FrostySdk.Ebx.WSVehiclePhysicsComponentData Data => data as FrostySdk.Ebx.WSVehiclePhysicsComponentData;
		public override string DisplayName => "WSVehiclePhysicsComponent";

		public WSVehiclePhysicsComponent(FrostySdk.Ebx.WSVehiclePhysicsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

