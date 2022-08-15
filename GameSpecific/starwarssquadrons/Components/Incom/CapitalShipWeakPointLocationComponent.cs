
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipWeakPointLocationComponentData))]
	public class CapitalShipWeakPointLocationComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipWeakPointLocationComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipWeakPointLocationComponentData Data => data as FrostySdk.Ebx.CapitalShipWeakPointLocationComponentData;
		public override string DisplayName => "CapitalShipWeakPointLocationComponent";

		public CapitalShipWeakPointLocationComponent(FrostySdk.Ebx.CapitalShipWeakPointLocationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

