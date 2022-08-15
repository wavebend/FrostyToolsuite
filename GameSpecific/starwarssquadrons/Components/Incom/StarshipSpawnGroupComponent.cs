
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipSpawnGroupComponentData))]
	public class StarshipSpawnGroupComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipSpawnGroupComponentData>
	{
		public new FrostySdk.Ebx.StarshipSpawnGroupComponentData Data => data as FrostySdk.Ebx.StarshipSpawnGroupComponentData;
		public override string DisplayName => "StarshipSpawnGroupComponent";

		public StarshipSpawnGroupComponent(FrostySdk.Ebx.StarshipSpawnGroupComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

