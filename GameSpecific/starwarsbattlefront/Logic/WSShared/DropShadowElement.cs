using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DropShadowElementData))]
	public class DropShadowElement : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.DropShadowElementData>
	{
		public new FrostySdk.Ebx.DropShadowElementData Data => data as FrostySdk.Ebx.DropShadowElementData;
		public override string DisplayName => "DropShadowElement";

		public DropShadowElement(FrostySdk.Ebx.DropShadowElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

