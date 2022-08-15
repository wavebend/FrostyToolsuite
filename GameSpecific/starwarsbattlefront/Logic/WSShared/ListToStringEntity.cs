using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ListToStringEntityData))]
	public class ListToStringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ListToStringEntityData>
	{
		public new FrostySdk.Ebx.ListToStringEntityData Data => data as FrostySdk.Ebx.ListToStringEntityData;
		public override string DisplayName => "ListToString";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ListToStringEntity(FrostySdk.Ebx.ListToStringEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

