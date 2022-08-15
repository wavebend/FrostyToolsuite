using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DoublePlayerEventCacheEntityData))]
	public class DoublePlayerEventCacheEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DoublePlayerEventCacheEntityData>
	{
		public new FrostySdk.Ebx.DoublePlayerEventCacheEntityData Data => data as FrostySdk.Ebx.DoublePlayerEventCacheEntityData;
		public override string DisplayName => "DoublePlayerEventCache";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DoublePlayerEventCacheEntity(FrostySdk.Ebx.DoublePlayerEventCacheEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

