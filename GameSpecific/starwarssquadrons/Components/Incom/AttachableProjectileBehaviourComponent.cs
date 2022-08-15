
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AttachableProjectileBehaviourComponentData))]
	public class AttachableProjectileBehaviourComponent : GameComponent, IEntityData<FrostySdk.Ebx.AttachableProjectileBehaviourComponentData>
	{
		public new FrostySdk.Ebx.AttachableProjectileBehaviourComponentData Data => data as FrostySdk.Ebx.AttachableProjectileBehaviourComponentData;
		public override string DisplayName => "AttachableProjectileBehaviourComponent";

		public AttachableProjectileBehaviourComponent(FrostySdk.Ebx.AttachableProjectileBehaviourComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

