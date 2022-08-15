
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRCollisionComponentData))]
	public class VRCollisionComponent : StaticModelPhysicsComponent, IEntityData<FrostySdk.Ebx.VRCollisionComponentData>
	{
		public new FrostySdk.Ebx.VRCollisionComponentData Data => data as FrostySdk.Ebx.VRCollisionComponentData;
		public override string DisplayName => "VRCollisionComponent";

		public VRCollisionComponent(FrostySdk.Ebx.VRCollisionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

