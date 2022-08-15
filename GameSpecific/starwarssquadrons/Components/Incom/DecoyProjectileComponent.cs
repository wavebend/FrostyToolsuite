
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DecoyProjectileComponentData))]
	public class DecoyProjectileComponent : GameComponent, IEntityData<FrostySdk.Ebx.DecoyProjectileComponentData>
	{
		public new FrostySdk.Ebx.DecoyProjectileComponentData Data => data as FrostySdk.Ebx.DecoyProjectileComponentData;
		public override string DisplayName => "DecoyProjectileComponent";

		public DecoyProjectileComponent(FrostySdk.Ebx.DecoyProjectileComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

