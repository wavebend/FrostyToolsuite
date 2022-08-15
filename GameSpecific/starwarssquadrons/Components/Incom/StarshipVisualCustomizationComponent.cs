
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipVisualCustomizationComponentData))]
	public class StarshipVisualCustomizationComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipVisualCustomizationComponentData>
	{
		public new FrostySdk.Ebx.StarshipVisualCustomizationComponentData Data => data as FrostySdk.Ebx.StarshipVisualCustomizationComponentData;
		public override string DisplayName => "StarshipVisualCustomizationComponent";

		public StarshipVisualCustomizationComponent(FrostySdk.Ebx.StarshipVisualCustomizationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

