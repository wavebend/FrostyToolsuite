
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ShadowControlComponentData))]
	public class ShadowControlComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.ShadowControlComponentData>
	{
		public new FrostySdk.Ebx.ShadowControlComponentData Data => data as FrostySdk.Ebx.ShadowControlComponentData;
		public override string DisplayName => "ShadowControlComponent";

		public ShadowControlComponent(FrostySdk.Ebx.ShadowControlComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

