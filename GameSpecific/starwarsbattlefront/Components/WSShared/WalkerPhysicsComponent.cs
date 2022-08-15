
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WalkerPhysicsComponentData))]
	public class WalkerPhysicsComponent : VehiclePhysicsComponent, IEntityData<FrostySdk.Ebx.WalkerPhysicsComponentData>
	{
		public new FrostySdk.Ebx.WalkerPhysicsComponentData Data => data as FrostySdk.Ebx.WalkerPhysicsComponentData;
		public override string DisplayName => "WalkerPhysicsComponent";

		public WalkerPhysicsComponent(FrostySdk.Ebx.WalkerPhysicsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

