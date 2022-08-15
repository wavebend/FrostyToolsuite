using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBotCommsAcknowledgementReceiverData))]
	public class IncomSquadronAIBotCommsAcknowledgementReceiver : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBotCommsAcknowledgementReceiverData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBotCommsAcknowledgementReceiverData Data => data as FrostySdk.Ebx.IncomSquadronAIBotCommsAcknowledgementReceiverData;
		public override string DisplayName => "IncomSquadronAIBotCommsAcknowledgementReceiver";

		public IncomSquadronAIBotCommsAcknowledgementReceiver(FrostySdk.Ebx.IncomSquadronAIBotCommsAcknowledgementReceiverData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

