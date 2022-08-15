using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementBitmapEntityData))]
	public class WSUIElementBitmapEntity : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementBitmapEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementBitmapEntityData Data => data as FrostySdk.Ebx.WSUIElementBitmapEntityData;
		public override string DisplayName => "WSUIElementBitmap";

		public WSUIElementBitmapEntity(FrostySdk.Ebx.WSUIElementBitmapEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

