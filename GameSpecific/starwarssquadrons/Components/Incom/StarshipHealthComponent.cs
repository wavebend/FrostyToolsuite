
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipHealthComponentData))]
	public class StarshipHealthComponent : ControllableHealthComponent, IEntityData<FrostySdk.Ebx.StarshipHealthComponentData>
	{
		public new FrostySdk.Ebx.StarshipHealthComponentData Data => data as FrostySdk.Ebx.StarshipHealthComponentData;
		public override string DisplayName => "StarshipHealthComponent";

		public StarshipHealthComponent(FrostySdk.Ebx.StarshipHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

