
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetLockBlockerComponentData))]
	public class TargetLockBlockerComponent : GameComponent, IEntityData<FrostySdk.Ebx.TargetLockBlockerComponentData>
	{
		public new FrostySdk.Ebx.TargetLockBlockerComponentData Data => data as FrostySdk.Ebx.TargetLockBlockerComponentData;
		public override string DisplayName => "TargetLockBlockerComponent";

		public TargetLockBlockerComponent(FrostySdk.Ebx.TargetLockBlockerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

