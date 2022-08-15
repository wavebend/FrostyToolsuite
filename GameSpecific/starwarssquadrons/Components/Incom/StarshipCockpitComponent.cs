
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipCockpitComponentData))]
	public class StarshipCockpitComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipCockpitComponentData>
	{
		public new FrostySdk.Ebx.StarshipCockpitComponentData Data => data as FrostySdk.Ebx.StarshipCockpitComponentData;
		public override string DisplayName => "StarshipCockpitComponent";

		public StarshipCockpitComponent(FrostySdk.Ebx.StarshipCockpitComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

