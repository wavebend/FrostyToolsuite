
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretTargetComputerComponentData))]
	public class TurretTargetComputerComponent : GameComponent, IEntityData<FrostySdk.Ebx.TurretTargetComputerComponentData>
	{
		public new FrostySdk.Ebx.TurretTargetComputerComponentData Data => data as FrostySdk.Ebx.TurretTargetComputerComponentData;
		public override string DisplayName => "TurretTargetComputerComponent";

		public TurretTargetComputerComponent(FrostySdk.Ebx.TurretTargetComputerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

