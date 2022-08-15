using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StartMatchmakingEntityData))]
	public class StartMatchmakingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StartMatchmakingEntityData>
	{
		public new FrostySdk.Ebx.StartMatchmakingEntityData Data => data as FrostySdk.Ebx.StartMatchmakingEntityData;
		public override string DisplayName => "StartMatchmaking";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public StartMatchmakingEntity(FrostySdk.Ebx.StartMatchmakingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

