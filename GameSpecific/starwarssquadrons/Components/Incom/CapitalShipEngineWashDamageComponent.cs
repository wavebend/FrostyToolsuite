
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipEngineWashDamageComponentData))]
	public class CapitalShipEngineWashDamageComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipEngineWashDamageComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipEngineWashDamageComponentData Data => data as FrostySdk.Ebx.CapitalShipEngineWashDamageComponentData;
		public override string DisplayName => "CapitalShipEngineWashDamageComponent";

		public CapitalShipEngineWashDamageComponent(FrostySdk.Ebx.CapitalShipEngineWashDamageComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

