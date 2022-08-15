
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OutlineColorsComponentData))]
	public class OutlineColorsComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.OutlineColorsComponentData>
	{
		public new FrostySdk.Ebx.OutlineColorsComponentData Data => data as FrostySdk.Ebx.OutlineColorsComponentData;
		public override string DisplayName => "OutlineColorsComponent";

		public OutlineColorsComponent(FrostySdk.Ebx.OutlineColorsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

