using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.XWingBlasterSelectorEntityData))]
	public class XWingBlasterSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.XWingBlasterSelectorEntityData>
	{
		public new FrostySdk.Ebx.XWingBlasterSelectorEntityData Data => data as FrostySdk.Ebx.XWingBlasterSelectorEntityData;
		public override string DisplayName => "XWingBlasterSelector";

		public XWingBlasterSelectorEntity(FrostySdk.Ebx.XWingBlasterSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

