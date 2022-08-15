
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomGraphicsParamsComponentData))]
	public class IncomGraphicsParamsComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.IncomGraphicsParamsComponentData>
	{
		public new FrostySdk.Ebx.IncomGraphicsParamsComponentData Data => data as FrostySdk.Ebx.IncomGraphicsParamsComponentData;
		public override string DisplayName => "IncomGraphicsParamsComponent";

		public IncomGraphicsParamsComponent(FrostySdk.Ebx.IncomGraphicsParamsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

