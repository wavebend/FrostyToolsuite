using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FocusFireReceiverEntityData))]
	public class FocusFireReceiverEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FocusFireReceiverEntityData>
	{
		public new FrostySdk.Ebx.FocusFireReceiverEntityData Data => data as FrostySdk.Ebx.FocusFireReceiverEntityData;
		public override string DisplayName => "FocusFireReceiver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public FocusFireReceiverEntity(FrostySdk.Ebx.FocusFireReceiverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

