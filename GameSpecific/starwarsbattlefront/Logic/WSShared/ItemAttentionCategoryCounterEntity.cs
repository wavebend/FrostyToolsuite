using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ItemAttentionCategoryCounterEntityData))]
	public class ItemAttentionCategoryCounterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ItemAttentionCategoryCounterEntityData>
	{
		public new FrostySdk.Ebx.ItemAttentionCategoryCounterEntityData Data => data as FrostySdk.Ebx.ItemAttentionCategoryCounterEntityData;
		public override string DisplayName => "ItemAttentionCategoryCounter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ItemAttentionCategoryCounterEntity(FrostySdk.Ebx.ItemAttentionCategoryCounterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

