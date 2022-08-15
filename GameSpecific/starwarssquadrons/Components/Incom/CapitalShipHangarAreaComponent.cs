
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipHangarAreaComponentData))]
	public class CapitalShipHangarAreaComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipHangarAreaComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipHangarAreaComponentData Data => data as FrostySdk.Ebx.CapitalShipHangarAreaComponentData;
		public override string DisplayName => "CapitalShipHangarAreaComponent";

		public CapitalShipHangarAreaComponent(FrostySdk.Ebx.CapitalShipHangarAreaComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

