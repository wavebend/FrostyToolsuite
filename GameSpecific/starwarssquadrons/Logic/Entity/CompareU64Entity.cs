using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompareU64EntityData))]
	public class CompareU64Entity : CompareEntityBase, IEntityData<FrostySdk.Ebx.CompareU64EntityData>
	{
		public new FrostySdk.Ebx.CompareU64EntityData Data => data as FrostySdk.Ebx.CompareU64EntityData;
		public override string DisplayName => "CompareU64";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CompareU64Entity(FrostySdk.Ebx.CompareU64EntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

