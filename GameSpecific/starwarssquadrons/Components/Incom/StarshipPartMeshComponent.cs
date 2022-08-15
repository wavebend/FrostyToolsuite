
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipPartMeshComponentData))]
	public class StarshipPartMeshComponent : MeshComponent, IEntityData<FrostySdk.Ebx.StarshipPartMeshComponentData>
	{
		public new FrostySdk.Ebx.StarshipPartMeshComponentData Data => data as FrostySdk.Ebx.StarshipPartMeshComponentData;
		public override string DisplayName => "StarshipPartMeshComponent";

		public StarshipPartMeshComponent(FrostySdk.Ebx.StarshipPartMeshComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

