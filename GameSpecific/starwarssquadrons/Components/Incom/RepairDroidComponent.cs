
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RepairDroidComponentData))]
	public class RepairDroidComponent : GameComponent, IEntityData<FrostySdk.Ebx.RepairDroidComponentData>
	{
		public new FrostySdk.Ebx.RepairDroidComponentData Data => data as FrostySdk.Ebx.RepairDroidComponentData;
		public override string DisplayName => "RepairDroidComponent";

		public RepairDroidComponent(FrostySdk.Ebx.RepairDroidComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

