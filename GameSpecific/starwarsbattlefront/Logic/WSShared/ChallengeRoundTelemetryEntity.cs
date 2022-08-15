using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ChallengeRoundTelemetryEntityData))]
	public class ChallengeRoundTelemetryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ChallengeRoundTelemetryEntityData>
	{
		public new FrostySdk.Ebx.ChallengeRoundTelemetryEntityData Data => data as FrostySdk.Ebx.ChallengeRoundTelemetryEntityData;
		public override string DisplayName => "ChallengeRoundTelemetry";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ChallengeRoundTelemetryEntity(FrostySdk.Ebx.ChallengeRoundTelemetryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

