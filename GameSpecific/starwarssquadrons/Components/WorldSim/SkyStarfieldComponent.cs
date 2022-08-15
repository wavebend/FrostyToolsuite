
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SkyStarfieldComponentData))]
	public class SkyStarfieldComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.SkyStarfieldComponentData>
	{
		public new FrostySdk.Ebx.SkyStarfieldComponentData Data => data as FrostySdk.Ebx.SkyStarfieldComponentData;
		public override string DisplayName => "SkyStarfieldComponent";

		public SkyStarfieldComponent(FrostySdk.Ebx.SkyStarfieldComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

