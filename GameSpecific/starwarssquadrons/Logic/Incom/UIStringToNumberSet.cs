using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIStringToNumberSetData))]
	public class UIStringToNumberSet : LogicEntity, IEntityData<FrostySdk.Ebx.UIStringToNumberSetData>
	{
		public new FrostySdk.Ebx.UIStringToNumberSetData Data => data as FrostySdk.Ebx.UIStringToNumberSetData;
		public override string DisplayName => "UIStringToNumberSet";

		public UIStringToNumberSet(FrostySdk.Ebx.UIStringToNumberSetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

