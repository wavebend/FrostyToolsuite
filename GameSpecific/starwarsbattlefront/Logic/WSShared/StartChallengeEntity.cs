using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StartChallengeEntityData))]
	public class StartChallengeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StartChallengeEntityData>
	{
		public new FrostySdk.Ebx.StartChallengeEntityData Data => data as FrostySdk.Ebx.StartChallengeEntityData;
		public override string DisplayName => "StartChallenge";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public StartChallengeEntity(FrostySdk.Ebx.StartChallengeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

