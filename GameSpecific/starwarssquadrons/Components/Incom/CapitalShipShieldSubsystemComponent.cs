
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipShieldSubsystemComponentData))]
	public class CapitalShipShieldSubsystemComponent : CapitalShipSubsystemComponent, IEntityData<FrostySdk.Ebx.CapitalShipShieldSubsystemComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipShieldSubsystemComponentData Data => data as FrostySdk.Ebx.CapitalShipShieldSubsystemComponentData;
		public override string DisplayName => "CapitalShipShieldSubsystemComponent";

		public CapitalShipShieldSubsystemComponent(FrostySdk.Ebx.CapitalShipShieldSubsystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

