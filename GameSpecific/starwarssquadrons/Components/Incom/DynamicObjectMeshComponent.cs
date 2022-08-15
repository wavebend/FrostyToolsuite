
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DynamicObjectMeshComponentData))]
	public class DynamicObjectMeshComponent : GameComponent, IEntityData<FrostySdk.Ebx.DynamicObjectMeshComponentData>
	{
		public new FrostySdk.Ebx.DynamicObjectMeshComponentData Data => data as FrostySdk.Ebx.DynamicObjectMeshComponentData;
		public override string DisplayName => "DynamicObjectMeshComponent";

		public DynamicObjectMeshComponent(FrostySdk.Ebx.DynamicObjectMeshComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

