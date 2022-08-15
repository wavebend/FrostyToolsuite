
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LobbyHMDReticleComponentData))]
	public class LobbyHMDReticleComponent : GameComponent, IEntityData<FrostySdk.Ebx.LobbyHMDReticleComponentData>
	{
		public new FrostySdk.Ebx.LobbyHMDReticleComponentData Data => data as FrostySdk.Ebx.LobbyHMDReticleComponentData;
		public override string DisplayName => "LobbyHMDReticleComponent";

		public LobbyHMDReticleComponent(FrostySdk.Ebx.LobbyHMDReticleComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

