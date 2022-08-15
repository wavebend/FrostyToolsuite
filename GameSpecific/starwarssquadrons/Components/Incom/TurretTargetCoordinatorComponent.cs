
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretTargetCoordinatorComponentData))]
	public class TurretTargetCoordinatorComponent : GameComponent, IEntityData<FrostySdk.Ebx.TurretTargetCoordinatorComponentData>
	{
		public new FrostySdk.Ebx.TurretTargetCoordinatorComponentData Data => data as FrostySdk.Ebx.TurretTargetCoordinatorComponentData;
		public override string DisplayName => "TurretTargetCoordinatorComponent";

		public TurretTargetCoordinatorComponent(FrostySdk.Ebx.TurretTargetCoordinatorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

