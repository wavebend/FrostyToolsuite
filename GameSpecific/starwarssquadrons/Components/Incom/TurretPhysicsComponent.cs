
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretPhysicsComponentData))]
	public class TurretPhysicsComponent : ControllablePhysicsComponent, IEntityData<FrostySdk.Ebx.TurretPhysicsComponentData>
	{
		public new FrostySdk.Ebx.TurretPhysicsComponentData Data => data as FrostySdk.Ebx.TurretPhysicsComponentData;
		public override string DisplayName => "TurretPhysicsComponent";

		public TurretPhysicsComponent(FrostySdk.Ebx.TurretPhysicsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

