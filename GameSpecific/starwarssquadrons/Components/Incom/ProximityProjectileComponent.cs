
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ProximityProjectileComponentData))]
	public class ProximityProjectileComponent : GameComponent, IEntityData<FrostySdk.Ebx.ProximityProjectileComponentData>
	{
		public new FrostySdk.Ebx.ProximityProjectileComponentData Data => data as FrostySdk.Ebx.ProximityProjectileComponentData;
		public override string DisplayName => "ProximityProjectileComponent";

		public ProximityProjectileComponent(FrostySdk.Ebx.ProximityProjectileComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

