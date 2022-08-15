
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ColorCorrectionMaskComponentData))]
	public class ColorCorrectionMaskComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.ColorCorrectionMaskComponentData>
	{
		public new FrostySdk.Ebx.ColorCorrectionMaskComponentData Data => data as FrostySdk.Ebx.ColorCorrectionMaskComponentData;
		public override string DisplayName => "ColorCorrectionMaskComponent";

		public ColorCorrectionMaskComponent(FrostySdk.Ebx.ColorCorrectionMaskComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

