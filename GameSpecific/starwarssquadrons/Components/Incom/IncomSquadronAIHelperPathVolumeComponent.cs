
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeComponentData))]
	public class IncomSquadronAIHelperPathVolumeComponent : GameComponent, IEntityData<FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeComponentData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeComponentData Data => data as FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeComponentData;
		public override string DisplayName => "IncomSquadronAIHelperPathVolumeComponent";

		public IncomSquadronAIHelperPathVolumeComponent(FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

