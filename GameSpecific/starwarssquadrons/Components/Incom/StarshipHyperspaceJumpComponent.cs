
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipHyperspaceJumpComponentData))]
	public class StarshipHyperspaceJumpComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipHyperspaceJumpComponentData>
	{
		public new FrostySdk.Ebx.StarshipHyperspaceJumpComponentData Data => data as FrostySdk.Ebx.StarshipHyperspaceJumpComponentData;
		public override string DisplayName => "StarshipHyperspaceJumpComponent";

		public StarshipHyperspaceJumpComponent(FrostySdk.Ebx.StarshipHyperspaceJumpComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

