
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommSystemComponentData))]
	public class CommSystemComponent : GameComponent, IEntityData<FrostySdk.Ebx.CommSystemComponentData>
	{
		public new FrostySdk.Ebx.CommSystemComponentData Data => data as FrostySdk.Ebx.CommSystemComponentData;
		public override string DisplayName => "CommSystemComponent";

		public CommSystemComponent(FrostySdk.Ebx.CommSystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

