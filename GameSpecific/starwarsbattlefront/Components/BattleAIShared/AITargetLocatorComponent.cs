
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AITargetLocatorComponentData))]
	public class AITargetLocatorComponent : GameComponent, IEntityData<FrostySdk.Ebx.AITargetLocatorComponentData>
	{
		public new FrostySdk.Ebx.AITargetLocatorComponentData Data => data as FrostySdk.Ebx.AITargetLocatorComponentData;
		public override string DisplayName => "AITargetLocatorComponent";

		public AITargetLocatorComponent(FrostySdk.Ebx.AITargetLocatorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

