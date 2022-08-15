
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PreIntegratedSubSurfaceScatteringComponentData))]
	public class PreIntegratedSubSurfaceScatteringComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.PreIntegratedSubSurfaceScatteringComponentData>
	{
		public new FrostySdk.Ebx.PreIntegratedSubSurfaceScatteringComponentData Data => data as FrostySdk.Ebx.PreIntegratedSubSurfaceScatteringComponentData;
		public override string DisplayName => "PreIntegratedSubSurfaceScatteringComponent";

		public PreIntegratedSubSurfaceScatteringComponent(FrostySdk.Ebx.PreIntegratedSubSurfaceScatteringComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

