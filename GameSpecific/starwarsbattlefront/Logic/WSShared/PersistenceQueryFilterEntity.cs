using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PersistenceQueryFilterEntityData))]
	public class PersistenceQueryFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PersistenceQueryFilterEntityData>
	{
		public new FrostySdk.Ebx.PersistenceQueryFilterEntityData Data => data as FrostySdk.Ebx.PersistenceQueryFilterEntityData;
		public override string DisplayName => "PersistenceQueryFilter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PersistenceQueryFilterEntity(FrostySdk.Ebx.PersistenceQueryFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

