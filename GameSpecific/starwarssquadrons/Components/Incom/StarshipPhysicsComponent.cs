
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipPhysicsComponentData))]
	public class StarshipPhysicsComponent : ControllablePhysicsComponent, IEntityData<FrostySdk.Ebx.StarshipPhysicsComponentData>
	{
		public new FrostySdk.Ebx.StarshipPhysicsComponentData Data => data as FrostySdk.Ebx.StarshipPhysicsComponentData;
		public override string DisplayName => "StarshipPhysicsComponent";

		public StarshipPhysicsComponent(FrostySdk.Ebx.StarshipPhysicsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

