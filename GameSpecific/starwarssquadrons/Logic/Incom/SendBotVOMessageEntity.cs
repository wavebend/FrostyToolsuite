using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SendBotVOMessageEntityData))]
	public class SendBotVOMessageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SendBotVOMessageEntityData>
	{
		public new FrostySdk.Ebx.SendBotVOMessageEntityData Data => data as FrostySdk.Ebx.SendBotVOMessageEntityData;
		public override string DisplayName => "SendBotVOMessage";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SendBotVOMessageEntity(FrostySdk.Ebx.SendBotVOMessageEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

