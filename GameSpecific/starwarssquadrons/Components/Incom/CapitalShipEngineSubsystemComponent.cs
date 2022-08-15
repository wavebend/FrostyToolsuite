
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipEngineSubsystemComponentData))]
	public class CapitalShipEngineSubsystemComponent : CapitalShipSubsystemComponent, IEntityData<FrostySdk.Ebx.CapitalShipEngineSubsystemComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipEngineSubsystemComponentData Data => data as FrostySdk.Ebx.CapitalShipEngineSubsystemComponentData;
		public override string DisplayName => "CapitalShipEngineSubsystemComponent";

		public CapitalShipEngineSubsystemComponent(FrostySdk.Ebx.CapitalShipEngineSubsystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

