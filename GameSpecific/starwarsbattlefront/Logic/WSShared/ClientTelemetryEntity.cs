using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientTelemetryEntityData))]
	public class ClientTelemetryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientTelemetryEntityData>
	{
		public new FrostySdk.Ebx.ClientTelemetryEntityData Data => data as FrostySdk.Ebx.ClientTelemetryEntityData;
		public override string DisplayName => "ClientTelemetry";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientTelemetryEntity(FrostySdk.Ebx.ClientTelemetryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

