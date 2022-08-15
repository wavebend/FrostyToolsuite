
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NavObstacleComponentData))]
	public class NavObstacleComponent : GameComponent, IEntityData<FrostySdk.Ebx.NavObstacleComponentData>
	{
		public new FrostySdk.Ebx.NavObstacleComponentData Data => data as FrostySdk.Ebx.NavObstacleComponentData;
		public override string DisplayName => "NavObstacleComponent";

		public NavObstacleComponent(FrostySdk.Ebx.NavObstacleComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

