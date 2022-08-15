
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GhostTurretsManagerComponentData))]
	public class GhostTurretsManagerComponent : GameComponent, IEntityData<FrostySdk.Ebx.GhostTurretsManagerComponentData>
	{
		public new FrostySdk.Ebx.GhostTurretsManagerComponentData Data => data as FrostySdk.Ebx.GhostTurretsManagerComponentData;
		public override string DisplayName => "GhostTurretsManagerComponent";

		public GhostTurretsManagerComponent(FrostySdk.Ebx.GhostTurretsManagerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

