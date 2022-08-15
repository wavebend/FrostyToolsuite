using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchSelectBoolEntityData))]
	public class CustomMatchSelectBoolEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchSelectBoolEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchSelectBoolEntityData Data => data as FrostySdk.Ebx.CustomMatchSelectBoolEntityData;
		public override string DisplayName => "CustomMatchSelectBool";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CustomMatchSelectBoolEntity(FrostySdk.Ebx.CustomMatchSelectBoolEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

