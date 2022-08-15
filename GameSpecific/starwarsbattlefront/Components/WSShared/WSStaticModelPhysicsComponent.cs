
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSStaticModelPhysicsComponentData))]
	public class WSStaticModelPhysicsComponent : StaticModelPhysicsComponent, IEntityData<FrostySdk.Ebx.WSStaticModelPhysicsComponentData>
	{
		public new FrostySdk.Ebx.WSStaticModelPhysicsComponentData Data => data as FrostySdk.Ebx.WSStaticModelPhysicsComponentData;
		public override string DisplayName => "WSStaticModelPhysicsComponent";

		public WSStaticModelPhysicsComponent(FrostySdk.Ebx.WSStaticModelPhysicsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

