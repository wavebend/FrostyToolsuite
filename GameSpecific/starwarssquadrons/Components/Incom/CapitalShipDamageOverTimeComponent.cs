
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipDamageOverTimeComponentData))]
	public class CapitalShipDamageOverTimeComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipDamageOverTimeComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipDamageOverTimeComponentData Data => data as FrostySdk.Ebx.CapitalShipDamageOverTimeComponentData;
		public override string DisplayName => "CapitalShipDamageOverTimeComponent";

		public CapitalShipDamageOverTimeComponent(FrostySdk.Ebx.CapitalShipDamageOverTimeComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

