using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MavericCrossPlayGateEntityData))]
	public class MavericCrossPlayGateEntity : MaverickGenericGateEntity, IEntityData<FrostySdk.Ebx.MavericCrossPlayGateEntityData>
	{
		public new FrostySdk.Ebx.MavericCrossPlayGateEntityData Data => data as FrostySdk.Ebx.MavericCrossPlayGateEntityData;
		public override string DisplayName => "MavericCrossPlayGate";

		public MavericCrossPlayGateEntity(FrostySdk.Ebx.MavericCrossPlayGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

