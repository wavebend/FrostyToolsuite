using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementRoundProgressBarEntityData))]
	public class WSUIElementRoundProgressBarEntity : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementRoundProgressBarEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementRoundProgressBarEntityData Data => data as FrostySdk.Ebx.WSUIElementRoundProgressBarEntityData;
		public override string DisplayName => "WSUIElementRoundProgressBar";

		public WSUIElementRoundProgressBarEntity(FrostySdk.Ebx.WSUIElementRoundProgressBarEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

