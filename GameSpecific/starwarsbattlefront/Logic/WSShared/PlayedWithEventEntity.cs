using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayedWithEventEntityData))]
	public class PlayedWithEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayedWithEventEntityData>
	{
		public new FrostySdk.Ebx.PlayedWithEventEntityData Data => data as FrostySdk.Ebx.PlayedWithEventEntityData;
		public override string DisplayName => "PlayedWithEvent";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayedWithEventEntity(FrostySdk.Ebx.PlayedWithEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

