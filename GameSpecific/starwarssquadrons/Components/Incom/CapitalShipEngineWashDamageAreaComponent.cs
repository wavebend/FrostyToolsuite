
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipEngineWashDamageAreaComponentData))]
	public class CapitalShipEngineWashDamageAreaComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipEngineWashDamageAreaComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipEngineWashDamageAreaComponentData Data => data as FrostySdk.Ebx.CapitalShipEngineWashDamageAreaComponentData;
		public override string DisplayName => "CapitalShipEngineWashDamageAreaComponent";

		public CapitalShipEngineWashDamageAreaComponent(FrostySdk.Ebx.CapitalShipEngineWashDamageAreaComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

