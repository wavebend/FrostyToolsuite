using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoiceOverPauseConversationEntityData))]
	public class VoiceOverPauseConversationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoiceOverPauseConversationEntityData>
	{
		public new FrostySdk.Ebx.VoiceOverPauseConversationEntityData Data => data as FrostySdk.Ebx.VoiceOverPauseConversationEntityData;
		public override string DisplayName => "VoiceOverPauseConversation";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VoiceOverPauseConversationEntity(FrostySdk.Ebx.VoiceOverPauseConversationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

