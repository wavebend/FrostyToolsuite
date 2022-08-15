using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IntToStringConverterEntityData))]
	public class IntToStringConverterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IntToStringConverterEntityData>
	{
		public new FrostySdk.Ebx.IntToStringConverterEntityData Data => data as FrostySdk.Ebx.IntToStringConverterEntityData;
		public override string DisplayName => "IntToStringConverter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IntToStringConverterEntity(FrostySdk.Ebx.IntToStringConverterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

