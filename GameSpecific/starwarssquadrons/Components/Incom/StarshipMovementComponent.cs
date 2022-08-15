
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipMovementComponentData))]
	public class StarshipMovementComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipMovementComponentData>
	{
		public new FrostySdk.Ebx.StarshipMovementComponentData Data => data as FrostySdk.Ebx.StarshipMovementComponentData;
		public override string DisplayName => "StarshipMovementComponent";

		public StarshipMovementComponent(FrostySdk.Ebx.StarshipMovementComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

