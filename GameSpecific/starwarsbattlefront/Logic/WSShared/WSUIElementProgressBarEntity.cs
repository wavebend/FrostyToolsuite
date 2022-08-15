using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementProgressBarEntityData))]
	public class WSUIElementProgressBarEntity : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementProgressBarEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementProgressBarEntityData Data => data as FrostySdk.Ebx.WSUIElementProgressBarEntityData;
		public override string DisplayName => "WSUIElementProgressBar";

		public WSUIElementProgressBarEntity(FrostySdk.Ebx.WSUIElementProgressBarEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

