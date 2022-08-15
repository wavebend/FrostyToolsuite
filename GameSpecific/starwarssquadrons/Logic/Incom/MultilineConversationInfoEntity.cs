using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MultilineConversationInfoEntityData))]
	public class MultilineConversationInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MultilineConversationInfoEntityData>
	{
		public new FrostySdk.Ebx.MultilineConversationInfoEntityData Data => data as FrostySdk.Ebx.MultilineConversationInfoEntityData;
		public override string DisplayName => "MultilineConversationInfo";

		public MultilineConversationInfoEntity(FrostySdk.Ebx.MultilineConversationInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

