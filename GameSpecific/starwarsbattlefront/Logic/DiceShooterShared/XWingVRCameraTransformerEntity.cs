using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.XWingVRCameraTransformerEntityData))]
	public class XWingVRCameraTransformerEntity : CameraTransformerEntity, IEntityData<FrostySdk.Ebx.XWingVRCameraTransformerEntityData>
	{
		public new FrostySdk.Ebx.XWingVRCameraTransformerEntityData Data => data as FrostySdk.Ebx.XWingVRCameraTransformerEntityData;
		public override string DisplayName => "XWingVRCameraTransformer";

		public XWingVRCameraTransformerEntity(FrostySdk.Ebx.XWingVRCameraTransformerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

