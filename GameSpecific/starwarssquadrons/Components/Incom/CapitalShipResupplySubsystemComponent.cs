
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipResupplySubsystemComponentData))]
	public class CapitalShipResupplySubsystemComponent : CapitalShipSubsystemComponent, IEntityData<FrostySdk.Ebx.CapitalShipResupplySubsystemComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipResupplySubsystemComponentData Data => data as FrostySdk.Ebx.CapitalShipResupplySubsystemComponentData;
		public override string DisplayName => "CapitalShipResupplySubsystemComponent";

		public CapitalShipResupplySubsystemComponent(FrostySdk.Ebx.CapitalShipResupplySubsystemComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

