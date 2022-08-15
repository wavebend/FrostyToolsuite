
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretHealthComponentData))]
	public class TurretHealthComponent : ControllableHealthComponent, IEntityData<FrostySdk.Ebx.TurretHealthComponentData>
	{
		public new FrostySdk.Ebx.TurretHealthComponentData Data => data as FrostySdk.Ebx.TurretHealthComponentData;
		public override string DisplayName => "TurretHealthComponent";

		public TurretHealthComponent(FrostySdk.Ebx.TurretHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

