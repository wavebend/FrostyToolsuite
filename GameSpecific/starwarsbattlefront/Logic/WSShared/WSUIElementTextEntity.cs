using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementTextEntityData))]
	public class WSUIElementTextEntity : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementTextEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementTextEntityData Data => data as FrostySdk.Ebx.WSUIElementTextEntityData;
		public override string DisplayName => "WSUIElementText";

		public WSUIElementTextEntity(FrostySdk.Ebx.WSUIElementTextEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

