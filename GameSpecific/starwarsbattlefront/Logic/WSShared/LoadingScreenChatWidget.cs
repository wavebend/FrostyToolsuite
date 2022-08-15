using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LoadingScreenChatWidgetData))]
	public class LoadingScreenChatWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.LoadingScreenChatWidgetData>
	{
		public new FrostySdk.Ebx.LoadingScreenChatWidgetData Data => data as FrostySdk.Ebx.LoadingScreenChatWidgetData;
		public override string DisplayName => "LoadingScreenChatWidget";

		public LoadingScreenChatWidget(FrostySdk.Ebx.LoadingScreenChatWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

