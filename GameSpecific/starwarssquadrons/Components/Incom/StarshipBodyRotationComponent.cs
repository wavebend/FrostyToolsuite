
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipBodyRotationComponentData))]
	public class StarshipBodyRotationComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipBodyRotationComponentData>
	{
		public new FrostySdk.Ebx.StarshipBodyRotationComponentData Data => data as FrostySdk.Ebx.StarshipBodyRotationComponentData;
		public override string DisplayName => "StarshipBodyRotationComponent";

		public StarshipBodyRotationComponent(FrostySdk.Ebx.StarshipBodyRotationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

