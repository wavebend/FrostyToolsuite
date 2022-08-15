
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerSpawnComponentData))]
	public class PlayerSpawnComponent : GameComponent, IEntityData<FrostySdk.Ebx.PlayerSpawnComponentData>
	{
		public new FrostySdk.Ebx.PlayerSpawnComponentData Data => data as FrostySdk.Ebx.PlayerSpawnComponentData;
		public override string DisplayName => "PlayerSpawnComponent";

		public PlayerSpawnComponent(FrostySdk.Ebx.PlayerSpawnComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

