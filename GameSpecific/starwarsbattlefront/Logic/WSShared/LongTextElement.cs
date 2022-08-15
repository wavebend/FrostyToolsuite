using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LongTextElementData))]
	public class LongTextElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.LongTextElementData>
	{
		public new FrostySdk.Ebx.LongTextElementData Data => data as FrostySdk.Ebx.LongTextElementData;
		public override string DisplayName => "LongTextElement";

		public LongTextElement(FrostySdk.Ebx.LongTextElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

