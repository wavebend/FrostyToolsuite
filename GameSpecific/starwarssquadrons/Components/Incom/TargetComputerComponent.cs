
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetComputerComponentData))]
	public class TargetComputerComponent : GameComponent, IEntityData<FrostySdk.Ebx.TargetComputerComponentData>
	{
		public new FrostySdk.Ebx.TargetComputerComponentData Data => data as FrostySdk.Ebx.TargetComputerComponentData;
		public override string DisplayName => "TargetComputerComponent";

		public TargetComputerComponent(FrostySdk.Ebx.TargetComputerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

