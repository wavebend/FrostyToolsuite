using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIChannelReferenceEntityData))]
	public class IncomSquadronAIChannelReferenceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIChannelReferenceEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIChannelReferenceEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIChannelReferenceEntityData;
		public override string DisplayName => "IncomSquadronAIChannelReference";

		public IncomSquadronAIChannelReferenceEntity(FrostySdk.Ebx.IncomSquadronAIChannelReferenceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

