
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VOComponentData))]
	public class VOComponent : GameComponent, IEntityData<FrostySdk.Ebx.VOComponentData>
	{
		public new FrostySdk.Ebx.VOComponentData Data => data as FrostySdk.Ebx.VOComponentData;
		public override string DisplayName => "VOComponent";

		public VOComponent(FrostySdk.Ebx.VOComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

