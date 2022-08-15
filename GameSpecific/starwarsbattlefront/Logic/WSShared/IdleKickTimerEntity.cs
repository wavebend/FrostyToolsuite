using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IdleKickTimerEntityData))]
	public class IdleKickTimerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IdleKickTimerEntityData>
	{
		public new FrostySdk.Ebx.IdleKickTimerEntityData Data => data as FrostySdk.Ebx.IdleKickTimerEntityData;
		public override string DisplayName => "IdleKickTimer";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IdleKickTimerEntity(FrostySdk.Ebx.IdleKickTimerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

