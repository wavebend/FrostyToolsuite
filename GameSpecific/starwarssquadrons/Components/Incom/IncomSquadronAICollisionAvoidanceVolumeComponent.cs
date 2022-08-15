
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeComponentData))]
	public class IncomSquadronAICollisionAvoidanceVolumeComponent : GameComponent, IEntityData<FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeComponentData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeComponentData Data => data as FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeComponentData;
		public override string DisplayName => "IncomSquadronAICollisionAvoidanceVolumeComponent";

		public IncomSquadronAICollisionAvoidanceVolumeComponent(FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

