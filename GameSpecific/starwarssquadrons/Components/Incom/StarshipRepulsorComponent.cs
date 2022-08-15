
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipRepulsorComponentData))]
	public class StarshipRepulsorComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipRepulsorComponentData>
	{
		public new FrostySdk.Ebx.StarshipRepulsorComponentData Data => data as FrostySdk.Ebx.StarshipRepulsorComponentData;
		public override string DisplayName => "StarshipRepulsorComponent";

		public StarshipRepulsorComponent(FrostySdk.Ebx.StarshipRepulsorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

