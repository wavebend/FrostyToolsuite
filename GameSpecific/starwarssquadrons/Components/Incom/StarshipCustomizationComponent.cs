
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipCustomizationComponentData))]
	public class StarshipCustomizationComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipCustomizationComponentData>
	{
		public new FrostySdk.Ebx.StarshipCustomizationComponentData Data => data as FrostySdk.Ebx.StarshipCustomizationComponentData;
		public override string DisplayName => "StarshipCustomizationComponent";

		public StarshipCustomizationComponent(FrostySdk.Ebx.StarshipCustomizationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

