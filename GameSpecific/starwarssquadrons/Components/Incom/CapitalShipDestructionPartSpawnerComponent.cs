
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapitalShipDestructionPartSpawnerComponentData))]
	public class CapitalShipDestructionPartSpawnerComponent : GameComponent, IEntityData<FrostySdk.Ebx.CapitalShipDestructionPartSpawnerComponentData>
	{
		public new FrostySdk.Ebx.CapitalShipDestructionPartSpawnerComponentData Data => data as FrostySdk.Ebx.CapitalShipDestructionPartSpawnerComponentData;
		public override string DisplayName => "CapitalShipDestructionPartSpawnerComponent";

		public CapitalShipDestructionPartSpawnerComponent(FrostySdk.Ebx.CapitalShipDestructionPartSpawnerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

