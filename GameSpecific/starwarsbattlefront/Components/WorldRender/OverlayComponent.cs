
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OverlayComponentData))]
	public class OverlayComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.OverlayComponentData>
	{
		public new FrostySdk.Ebx.OverlayComponentData Data => data as FrostySdk.Ebx.OverlayComponentData;
		public override string DisplayName => "OverlayComponent";

		public OverlayComponent(FrostySdk.Ebx.OverlayComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

