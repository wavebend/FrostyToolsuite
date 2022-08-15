using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PreMatchmakingChecksEntityData))]
	public class PreMatchmakingChecksEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PreMatchmakingChecksEntityData>
	{
		public new FrostySdk.Ebx.PreMatchmakingChecksEntityData Data => data as FrostySdk.Ebx.PreMatchmakingChecksEntityData;
		public override string DisplayName => "PreMatchmakingChecks";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PreMatchmakingChecksEntity(FrostySdk.Ebx.PreMatchmakingChecksEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

