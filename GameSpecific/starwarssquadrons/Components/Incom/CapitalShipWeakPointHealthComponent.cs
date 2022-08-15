
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipWeakPointHealthComponentData))]
	public class CapitalShipWeakPointHealthComponent : BangerHealthComponent, IEntityData<FrostySdk.Ebx.CapitalShipWeakPointHealthComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipWeakPointHealthComponentData Data => data as FrostySdk.Ebx.CapitalShipWeakPointHealthComponentData;
		public override string DisplayName => "CapitalShipWeakPointHealthComponent";

		public CapitalShipWeakPointHealthComponent(FrostySdk.Ebx.CapitalShipWeakPointHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

