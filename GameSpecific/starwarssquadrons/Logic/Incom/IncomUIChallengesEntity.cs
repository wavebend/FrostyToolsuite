using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIChallengesEntityData))]
	public class IncomUIChallengesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIChallengesEntityData>
	{
		public new FrostySdk.Ebx.IncomUIChallengesEntityData Data => data as FrostySdk.Ebx.IncomUIChallengesEntityData;
		public override string DisplayName => "IncomUIChallenges";

		public IncomUIChallengesEntity(FrostySdk.Ebx.IncomUIChallengesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

