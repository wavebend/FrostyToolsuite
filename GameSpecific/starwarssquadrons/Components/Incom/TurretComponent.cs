
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretComponentData))]
	public class TurretComponent : GameComponent, IEntityData<FrostySdk.Ebx.TurretComponentData>
	{
		public new FrostySdk.Ebx.TurretComponentData Data => data as FrostySdk.Ebx.TurretComponentData;
		public override string DisplayName => "TurretComponent";

		public TurretComponent(FrostySdk.Ebx.TurretComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

