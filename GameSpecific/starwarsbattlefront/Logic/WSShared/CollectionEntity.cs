using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CollectionEntityData))]
	public class CollectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CollectionEntityData>
	{
		public new FrostySdk.Ebx.CollectionEntityData Data => data as FrostySdk.Ebx.CollectionEntityData;
		public override string DisplayName => "Collection";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CollectionEntity(FrostySdk.Ebx.CollectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

