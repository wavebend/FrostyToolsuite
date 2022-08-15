using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CombinedTextElementData))]
	public class CombinedTextElement : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.CombinedTextElementData>
	{
		public new FrostySdk.Ebx.CombinedTextElementData Data => data as FrostySdk.Ebx.CombinedTextElementData;
		public override string DisplayName => "CombinedTextElement";

		public CombinedTextElement(FrostySdk.Ebx.CombinedTextElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

