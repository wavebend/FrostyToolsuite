
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipSpawnLocationComponentData))]
	public class StarshipSpawnLocationComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipSpawnLocationComponentData>
	{
		public new FrostySdk.Ebx.StarshipSpawnLocationComponentData Data => data as FrostySdk.Ebx.StarshipSpawnLocationComponentData;
		public override string DisplayName => "StarshipSpawnLocationComponent";

		public StarshipSpawnLocationComponent(FrostySdk.Ebx.StarshipSpawnLocationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

