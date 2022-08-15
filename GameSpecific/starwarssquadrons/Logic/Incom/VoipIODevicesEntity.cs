using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoipIODevicesEntityData))]
	public class VoipIODevicesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoipIODevicesEntityData>
	{
		public new FrostySdk.Ebx.VoipIODevicesEntityData Data => data as FrostySdk.Ebx.VoipIODevicesEntityData;
		public override string DisplayName => "VoipIODevices";

		public VoipIODevicesEntity(FrostySdk.Ebx.VoipIODevicesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

