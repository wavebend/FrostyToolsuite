
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipHealthComponentData))]
	public class CapitalShipHealthComponent : ControllableHealthComponent, IEntityData<FrostySdk.Ebx.CapitalShipHealthComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipHealthComponentData Data => data as FrostySdk.Ebx.CapitalShipHealthComponentData;
		public override string DisplayName => "CapitalShipHealthComponent";

		public CapitalShipHealthComponent(FrostySdk.Ebx.CapitalShipHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

