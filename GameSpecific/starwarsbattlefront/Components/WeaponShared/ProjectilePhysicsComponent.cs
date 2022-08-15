
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ProjectilePhysicsComponentData))]
	public class ProjectilePhysicsComponent : GamePhysicsComponent, IEntityData<FrostySdk.Ebx.ProjectilePhysicsComponentData>
	{
		public new FrostySdk.Ebx.ProjectilePhysicsComponentData Data => data as FrostySdk.Ebx.ProjectilePhysicsComponentData;
		public override string DisplayName => "ProjectilePhysicsComponent";

		public ProjectilePhysicsComponent(FrostySdk.Ebx.ProjectilePhysicsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

