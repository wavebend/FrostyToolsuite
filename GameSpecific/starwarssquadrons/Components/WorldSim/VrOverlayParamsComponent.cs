
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VrOverlayParamsComponentData))]
	public class VrOverlayParamsComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.VrOverlayParamsComponentData>
	{
		public new FrostySdk.Ebx.VrOverlayParamsComponentData Data => data as FrostySdk.Ebx.VrOverlayParamsComponentData;
		public override string DisplayName => "VrOverlayParamsComponent";

		public VrOverlayParamsComponent(FrostySdk.Ebx.VrOverlayParamsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

