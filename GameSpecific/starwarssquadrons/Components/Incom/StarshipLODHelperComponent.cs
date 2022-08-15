
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipLODHelperComponentData))]
	public class StarshipLODHelperComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipLODHelperComponentData>
	{
		public new FrostySdk.Ebx.StarshipLODHelperComponentData Data => data as FrostySdk.Ebx.StarshipLODHelperComponentData;
		public override string DisplayName => "StarshipLODHelperComponent";

		public StarshipLODHelperComponent(FrostySdk.Ebx.StarshipLODHelperComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

