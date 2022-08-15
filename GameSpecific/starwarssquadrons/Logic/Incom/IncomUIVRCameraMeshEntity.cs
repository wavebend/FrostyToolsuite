using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIVRCameraMeshEntityData))]
	public class IncomUIVRCameraMeshEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIVRCameraMeshEntityData>
	{
		public new FrostySdk.Ebx.IncomUIVRCameraMeshEntityData Data => data as FrostySdk.Ebx.IncomUIVRCameraMeshEntityData;
		public override string DisplayName => "IncomUIVRCameraMesh";

		public IncomUIVRCameraMeshEntity(FrostySdk.Ebx.IncomUIVRCameraMeshEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

