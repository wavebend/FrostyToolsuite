
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipAttachComponentData))]
	public class CapitalShipAttachComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipAttachComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipAttachComponentData Data => data as FrostySdk.Ebx.CapitalShipAttachComponentData;
		public override string DisplayName => "CapitalShipAttachComponent";

		public CapitalShipAttachComponent(FrostySdk.Ebx.CapitalShipAttachComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

