
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ZPassControlComponentData))]
	public class ZPassControlComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.ZPassControlComponentData>
	{
		public new FrostySdk.Ebx.ZPassControlComponentData Data => data as FrostySdk.Ebx.ZPassControlComponentData;
		public override string DisplayName => "ZPassControlComponent";

		public ZPassControlComponent(FrostySdk.Ebx.ZPassControlComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

