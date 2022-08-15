
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDriverComponentData))]
	public class IncomSquadronAIDriverComponent : GameComponent, IEntityData<FrostySdk.Ebx.IncomSquadronAIDriverComponentData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDriverComponentData Data => data as FrostySdk.Ebx.IncomSquadronAIDriverComponentData;
		public override string DisplayName => "IncomSquadronAIDriverComponent";

		public IncomSquadronAIDriverComponent(FrostySdk.Ebx.IncomSquadronAIDriverComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

