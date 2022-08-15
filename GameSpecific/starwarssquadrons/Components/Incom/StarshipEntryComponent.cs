
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipEntryComponentData))]
	public class StarshipEntryComponent : EntryComponent, IEntityData<FrostySdk.Ebx.StarshipEntryComponentData>
	{
		public new FrostySdk.Ebx.StarshipEntryComponentData Data => data as FrostySdk.Ebx.StarshipEntryComponentData;
		public override string DisplayName => "StarshipEntryComponent";

		public StarshipEntryComponent(FrostySdk.Ebx.StarshipEntryComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

