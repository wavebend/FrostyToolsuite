using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomScreenshotCaptureQueueEntityData))]
	public class IncomScreenshotCaptureQueueEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomScreenshotCaptureQueueEntityData>
	{
		public new FrostySdk.Ebx.IncomScreenshotCaptureQueueEntityData Data => data as FrostySdk.Ebx.IncomScreenshotCaptureQueueEntityData;
		public override string DisplayName => "IncomScreenshotCaptureQueue";

		public IncomScreenshotCaptureQueueEntity(FrostySdk.Ebx.IncomScreenshotCaptureQueueEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

