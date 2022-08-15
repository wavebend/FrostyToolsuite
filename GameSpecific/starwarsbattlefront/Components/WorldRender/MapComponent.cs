
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MapComponentData))]
	public class MapComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.MapComponentData>
	{
		public new FrostySdk.Ebx.MapComponentData Data => data as FrostySdk.Ebx.MapComponentData;
		public override string DisplayName => "MapComponent";

		public MapComponent(FrostySdk.Ebx.MapComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

