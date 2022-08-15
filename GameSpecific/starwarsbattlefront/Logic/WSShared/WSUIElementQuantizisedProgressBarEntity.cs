using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementQuantizisedProgressBarEntityData))]
	public class WSUIElementQuantizisedProgressBarEntity : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementQuantizisedProgressBarEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementQuantizisedProgressBarEntityData Data => data as FrostySdk.Ebx.WSUIElementQuantizisedProgressBarEntityData;
		public override string DisplayName => "WSUIElementQuantizisedProgressBar";

		public WSUIElementQuantizisedProgressBarEntity(FrostySdk.Ebx.WSUIElementQuantizisedProgressBarEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

