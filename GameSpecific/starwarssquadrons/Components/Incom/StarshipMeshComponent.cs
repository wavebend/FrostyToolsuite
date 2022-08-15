
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipMeshComponentData))]
	public class StarshipMeshComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipMeshComponentData>
	{
		public new FrostySdk.Ebx.StarshipMeshComponentData Data => data as FrostySdk.Ebx.StarshipMeshComponentData;
		public override string DisplayName => "StarshipMeshComponent";

		public StarshipMeshComponent(FrostySdk.Ebx.StarshipMeshComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

