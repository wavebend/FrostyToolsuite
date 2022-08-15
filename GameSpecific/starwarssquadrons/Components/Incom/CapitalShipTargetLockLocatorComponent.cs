
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipTargetLockLocatorComponentData))]
	public class CapitalShipTargetLockLocatorComponent : LocatorComponent, IEntityData<FrostySdk.Ebx.CapitalShipTargetLockLocatorComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipTargetLockLocatorComponentData Data => data as FrostySdk.Ebx.CapitalShipTargetLockLocatorComponentData;
		public override string DisplayName => "CapitalShipTargetLockLocatorComponent";

		public CapitalShipTargetLockLocatorComponent(FrostySdk.Ebx.CapitalShipTargetLockLocatorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

