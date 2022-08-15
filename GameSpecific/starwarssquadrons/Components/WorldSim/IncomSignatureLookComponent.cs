
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSignatureLookComponentData))]
	public class IncomSignatureLookComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.IncomSignatureLookComponentData>
	{
		public new FrostySdk.Ebx.IncomSignatureLookComponentData Data => data as FrostySdk.Ebx.IncomSignatureLookComponentData;
		public override string DisplayName => "IncomSignatureLookComponent";

		public IncomSignatureLookComponent(FrostySdk.Ebx.IncomSignatureLookComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

