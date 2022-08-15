using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LoadingScreenChatEntryWidgetData))]
	public class LoadingScreenChatEntryWidget : ChatListCellWidget, IEntityData<FrostySdk.Ebx.LoadingScreenChatEntryWidgetData>
	{
		public new FrostySdk.Ebx.LoadingScreenChatEntryWidgetData Data => data as FrostySdk.Ebx.LoadingScreenChatEntryWidgetData;
		public override string DisplayName => "LoadingScreenChatEntryWidget";

		public LoadingScreenChatEntryWidget(FrostySdk.Ebx.LoadingScreenChatEntryWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

