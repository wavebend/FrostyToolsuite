using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIProtectFriendlyBehaviourEntityData))]
	public class IncomSquadronAIProtectFriendlyBehaviourEntity : IncomSquadronAIBehaviourEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIProtectFriendlyBehaviourEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIProtectFriendlyBehaviourEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIProtectFriendlyBehaviourEntityData;
		public override string DisplayName => "IncomSquadronAIProtectFriendlyBehaviour";

		public IncomSquadronAIProtectFriendlyBehaviourEntity(FrostySdk.Ebx.IncomSquadronAIProtectFriendlyBehaviourEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

