using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PeerHostChallengeEntityData))]
	public class PeerHostChallengeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PeerHostChallengeEntityData>
	{
		public new FrostySdk.Ebx.PeerHostChallengeEntityData Data => data as FrostySdk.Ebx.PeerHostChallengeEntityData;
		public override string DisplayName => "PeerHostChallenge";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PeerHostChallengeEntity(FrostySdk.Ebx.PeerHostChallengeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

