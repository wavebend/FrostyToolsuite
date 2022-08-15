using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.U64EntityData))]
	public class U64Entity : LogicEntity, IEntityData<FrostySdk.Ebx.U64EntityData>
	{
		public new FrostySdk.Ebx.U64EntityData Data => data as FrostySdk.Ebx.U64EntityData;
		public override string DisplayName => "U64";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public U64Entity(FrostySdk.Ebx.U64EntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

