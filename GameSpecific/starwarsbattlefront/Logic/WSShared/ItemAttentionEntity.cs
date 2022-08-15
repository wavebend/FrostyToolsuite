using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ItemAttentionEntityData))]
	public class ItemAttentionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ItemAttentionEntityData>
	{
		public new FrostySdk.Ebx.ItemAttentionEntityData Data => data as FrostySdk.Ebx.ItemAttentionEntityData;
		public override string DisplayName => "ItemAttention";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ItemAttentionEntity(FrostySdk.Ebx.ItemAttentionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

