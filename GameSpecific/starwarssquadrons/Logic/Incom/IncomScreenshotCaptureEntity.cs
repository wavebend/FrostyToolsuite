using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomScreenshotCaptureEntityData))]
	public class IncomScreenshotCaptureEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomScreenshotCaptureEntityData>
	{
		public new FrostySdk.Ebx.IncomScreenshotCaptureEntityData Data => data as FrostySdk.Ebx.IncomScreenshotCaptureEntityData;
		public override string DisplayName => "IncomScreenshotCapture";

		public IncomScreenshotCaptureEntity(FrostySdk.Ebx.IncomScreenshotCaptureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

