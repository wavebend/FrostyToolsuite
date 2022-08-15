using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VrTrackedDeviceEntityData))]
	public class VrTrackedDeviceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VrTrackedDeviceEntityData>
	{
		public new FrostySdk.Ebx.VrTrackedDeviceEntityData Data => data as FrostySdk.Ebx.VrTrackedDeviceEntityData;
		public override string DisplayName => "VrTrackedDevice";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VrTrackedDeviceEntity(FrostySdk.Ebx.VrTrackedDeviceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

