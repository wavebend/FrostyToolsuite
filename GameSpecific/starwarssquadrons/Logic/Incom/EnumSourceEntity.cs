using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EnumSourceEntityData))]
	public class EnumSourceEntity : ExplicitEnumTypeLogicEntity, IEntityData<FrostySdk.Ebx.EnumSourceEntityData>
	{
		public new FrostySdk.Ebx.EnumSourceEntityData Data => data as FrostySdk.Ebx.EnumSourceEntityData;
		public override string DisplayName => "EnumSource";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public EnumSourceEntity(FrostySdk.Ebx.EnumSourceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

