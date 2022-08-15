using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVRPilotEntityData))]
	public class WSVRPilotEntity : PilotEntityBase, IEntityData<FrostySdk.Ebx.WSVRPilotEntityData>
	{
		public new FrostySdk.Ebx.WSVRPilotEntityData Data => data as FrostySdk.Ebx.WSVRPilotEntityData;
		public override string DisplayName => "WSVRPilot";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public WSVRPilotEntity(FrostySdk.Ebx.WSVRPilotEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

