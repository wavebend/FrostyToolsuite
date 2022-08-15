using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRTransformProxyData))]
	public class VRTransformProxy : LogicEntity, IEntityData<FrostySdk.Ebx.VRTransformProxyData>
	{
		public new FrostySdk.Ebx.VRTransformProxyData Data => data as FrostySdk.Ebx.VRTransformProxyData;
		public override string DisplayName => "VRTransformProxy";

		public VRTransformProxy(FrostySdk.Ebx.VRTransformProxyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

