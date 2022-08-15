
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SuperDefenseMissileComponentData))]
	public class SuperDefenseMissileComponent : GameComponent, IEntityData<FrostySdk.Ebx.SuperDefenseMissileComponentData>
	{
		public new FrostySdk.Ebx.SuperDefenseMissileComponentData Data => data as FrostySdk.Ebx.SuperDefenseMissileComponentData;
		public override string DisplayName => "SuperDefenseMissileComponent";

		public SuperDefenseMissileComponent(FrostySdk.Ebx.SuperDefenseMissileComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

