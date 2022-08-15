
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AreaTriggerComponentData))]
	public class AreaTriggerComponent : GameComponent, IEntityData<FrostySdk.Ebx.AreaTriggerComponentData>
	{
		public new FrostySdk.Ebx.AreaTriggerComponentData Data => data as FrostySdk.Ebx.AreaTriggerComponentData;
		public override string DisplayName => "AreaTriggerComponent";

		public AreaTriggerComponent(FrostySdk.Ebx.AreaTriggerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

