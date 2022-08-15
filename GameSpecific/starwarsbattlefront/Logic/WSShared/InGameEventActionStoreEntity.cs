using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InGameEventActionStoreEntityData))]
	public class InGameEventActionStoreEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InGameEventActionStoreEntityData>
	{
		public new FrostySdk.Ebx.InGameEventActionStoreEntityData Data => data as FrostySdk.Ebx.InGameEventActionStoreEntityData;
		public override string DisplayName => "InGameEventActionStore";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public InGameEventActionStoreEntity(FrostySdk.Ebx.InGameEventActionStoreEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

