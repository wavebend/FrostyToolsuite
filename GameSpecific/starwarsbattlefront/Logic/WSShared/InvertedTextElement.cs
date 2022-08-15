using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InvertedTextElementData))]
	public class InvertedTextElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.InvertedTextElementData>
	{
		public new FrostySdk.Ebx.InvertedTextElementData Data => data as FrostySdk.Ebx.InvertedTextElementData;
		public override string DisplayName => "InvertedTextElement";

		public InvertedTextElement(FrostySdk.Ebx.InvertedTextElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

