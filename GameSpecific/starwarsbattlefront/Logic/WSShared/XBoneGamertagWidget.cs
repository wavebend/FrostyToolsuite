using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.XBoneGamertagWidgetData))]
	public class XBoneGamertagWidget : WSUIWidgetEntity, IEntityData<FrostySdk.Ebx.XBoneGamertagWidgetData>
	{
		public new FrostySdk.Ebx.XBoneGamertagWidgetData Data => data as FrostySdk.Ebx.XBoneGamertagWidgetData;
		public override string DisplayName => "XBoneGamertagWidget";

		public XBoneGamertagWidget(FrostySdk.Ebx.XBoneGamertagWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

