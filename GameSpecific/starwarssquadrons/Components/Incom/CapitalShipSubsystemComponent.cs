
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipSubsystemComponentData))]
	public class CapitalShipSubsystemComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipSubsystemComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipSubsystemComponentData Data => data as FrostySdk.Ebx.CapitalShipSubsystemComponentData;
		public override string DisplayName => "CapitalShipSubsystemComponent";

		public CapitalShipSubsystemComponent(FrostySdk.Ebx.CapitalShipSubsystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

