
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipPowerGridSubsystemComponentData))]
	public class CapitalShipPowerGridSubsystemComponent : CapitalShipSubsystemComponent, IEntityData<FrostySdk.Ebx.CapitalShipPowerGridSubsystemComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipPowerGridSubsystemComponentData Data => data as FrostySdk.Ebx.CapitalShipPowerGridSubsystemComponentData;
		public override string DisplayName => "CapitalShipPowerGridSubsystemComponent";

		public CapitalShipPowerGridSubsystemComponent(FrostySdk.Ebx.CapitalShipPowerGridSubsystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

