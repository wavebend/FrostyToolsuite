
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LobbyReplicationComponentData))]
	public class LobbyReplicationComponent : GameComponent, IEntityData<FrostySdk.Ebx.LobbyReplicationComponentData>
	{
		public new FrostySdk.Ebx.LobbyReplicationComponentData Data => data as FrostySdk.Ebx.LobbyReplicationComponentData;
		public override string DisplayName => "LobbyReplicationComponent";

		public LobbyReplicationComponent(FrostySdk.Ebx.LobbyReplicationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

