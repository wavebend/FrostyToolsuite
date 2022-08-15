using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IndexSelectorEntityData))]
	public class IndexSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IndexSelectorEntityData>
	{
		public new FrostySdk.Ebx.IndexSelectorEntityData Data => data as FrostySdk.Ebx.IndexSelectorEntityData;
		public override string DisplayName => "IndexSelector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IndexSelectorEntity(FrostySdk.Ebx.IndexSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

