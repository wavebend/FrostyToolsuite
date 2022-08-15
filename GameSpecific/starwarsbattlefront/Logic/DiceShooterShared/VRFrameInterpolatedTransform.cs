using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRFrameInterpolatedTransformData))]
	public class VRFrameInterpolatedTransform : FrameInterpolatedTransform, IEntityData<FrostySdk.Ebx.VRFrameInterpolatedTransformData>
	{
		public new FrostySdk.Ebx.VRFrameInterpolatedTransformData Data => data as FrostySdk.Ebx.VRFrameInterpolatedTransformData;
		public override string DisplayName => "VRFrameInterpolatedTransform";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRFrameInterpolatedTransform(FrostySdk.Ebx.VRFrameInterpolatedTransformData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

