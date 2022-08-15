
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipAttributesComponentData))]
	public class StarshipAttributesComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipAttributesComponentData>
	{
		public new FrostySdk.Ebx.StarshipAttributesComponentData Data => data as FrostySdk.Ebx.StarshipAttributesComponentData;
		public override string DisplayName => "StarshipAttributesComponent";

		public StarshipAttributesComponent(FrostySdk.Ebx.StarshipAttributesComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

