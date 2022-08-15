using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ServerTelemetryEntityData))]
	public class ServerTelemetryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ServerTelemetryEntityData>
	{
		public new FrostySdk.Ebx.ServerTelemetryEntityData Data => data as FrostySdk.Ebx.ServerTelemetryEntityData;
		public override string DisplayName => "ServerTelemetry";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ServerTelemetryEntity(FrostySdk.Ebx.ServerTelemetryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

