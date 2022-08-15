
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MeshCelestialParamsComponentData))]
	public class MeshCelestialParamsComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.MeshCelestialParamsComponentData>
	{
		public new FrostySdk.Ebx.MeshCelestialParamsComponentData Data => data as FrostySdk.Ebx.MeshCelestialParamsComponentData;
		public override string DisplayName => "MeshCelestialParamsComponent";

		public MeshCelestialParamsComponent(FrostySdk.Ebx.MeshCelestialParamsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

