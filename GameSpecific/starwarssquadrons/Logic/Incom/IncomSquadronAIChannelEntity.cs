using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIChannelEntityData))]
	public class IncomSquadronAIChannelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIChannelEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIChannelEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIChannelEntityData;
		public override string DisplayName => "IncomSquadronAIChannel";

		public IncomSquadronAIChannelEntity(FrostySdk.Ebx.IncomSquadronAIChannelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

