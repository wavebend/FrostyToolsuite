
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretAimingComponentData))]
	public class TurretAimingComponent : GameComponent, IEntityData<FrostySdk.Ebx.TurretAimingComponentData>
	{
		public new FrostySdk.Ebx.TurretAimingComponentData Data => data as FrostySdk.Ebx.TurretAimingComponentData;
		public override string DisplayName => "TurretAimingComponent";

		public TurretAimingComponent(FrostySdk.Ebx.TurretAimingComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

