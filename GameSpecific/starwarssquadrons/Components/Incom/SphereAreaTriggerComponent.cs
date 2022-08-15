
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SphereAreaTriggerComponentData))]
	public class SphereAreaTriggerComponent : AreaTriggerComponent, IEntityData<FrostySdk.Ebx.SphereAreaTriggerComponentData>
	{
		public new FrostySdk.Ebx.SphereAreaTriggerComponentData Data => data as FrostySdk.Ebx.SphereAreaTriggerComponentData;
		public override string DisplayName => "SphereAreaTriggerComponent";

		public SphereAreaTriggerComponent(FrostySdk.Ebx.SphereAreaTriggerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

