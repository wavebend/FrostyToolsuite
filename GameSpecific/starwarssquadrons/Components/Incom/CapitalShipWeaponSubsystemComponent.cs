
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipWeaponSubsystemComponentData))]
	public class CapitalShipWeaponSubsystemComponent : CapitalShipSubsystemComponent, IEntityData<FrostySdk.Ebx.CapitalShipWeaponSubsystemComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipWeaponSubsystemComponentData Data => data as FrostySdk.Ebx.CapitalShipWeaponSubsystemComponentData;
		public override string DisplayName => "CapitalShipWeaponSubsystemComponent";

		public CapitalShipWeaponSubsystemComponent(FrostySdk.Ebx.CapitalShipWeaponSubsystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

