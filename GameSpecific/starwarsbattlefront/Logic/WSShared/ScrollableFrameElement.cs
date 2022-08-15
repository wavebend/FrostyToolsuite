using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ScrollableFrameElementData))]
	public class ScrollableFrameElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.ScrollableFrameElementData>
	{
		public new FrostySdk.Ebx.ScrollableFrameElementData Data => data as FrostySdk.Ebx.ScrollableFrameElementData;
		public override string DisplayName => "ScrollableFrameElement";

		public ScrollableFrameElement(FrostySdk.Ebx.ScrollableFrameElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

