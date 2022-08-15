using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRTrackedDeviceEntityData))]
	public class VRTrackedDeviceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VRTrackedDeviceEntityData>
	{
		public new FrostySdk.Ebx.VRTrackedDeviceEntityData Data => data as FrostySdk.Ebx.VRTrackedDeviceEntityData;
		public override string DisplayName => "VRTrackedDevice";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRTrackedDeviceEntity(FrostySdk.Ebx.VRTrackedDeviceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

