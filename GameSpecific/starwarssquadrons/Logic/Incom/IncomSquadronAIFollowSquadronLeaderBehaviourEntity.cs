using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIFollowSquadronLeaderBehaviourEntityData))]
	public class IncomSquadronAIFollowSquadronLeaderBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIFollowSquadronLeaderBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIFollowSquadronLeaderBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIFollowSquadronLeaderBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIFollowSquadronLeaderBehaviour";

		public IncomSquadronAIFollowSquadronLeaderBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIFollowSquadronLeaderBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

