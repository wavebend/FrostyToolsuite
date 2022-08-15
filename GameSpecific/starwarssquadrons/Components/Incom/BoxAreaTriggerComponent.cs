
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BoxAreaTriggerComponentData))]
	public class BoxAreaTriggerComponent : AreaTriggerComponent, IEntityData<FrostySdk.Ebx.BoxAreaTriggerComponentData>
	{
		public new FrostySdk.Ebx.BoxAreaTriggerComponentData Data => data as FrostySdk.Ebx.BoxAreaTriggerComponentData;
		public override string DisplayName => "BoxAreaTriggerComponent";

		public BoxAreaTriggerComponent(FrostySdk.Ebx.BoxAreaTriggerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

