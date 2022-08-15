using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchSelectFloatEntityData))]
	public class CustomMatchSelectFloatEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchSelectFloatEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchSelectFloatEntityData Data => data as FrostySdk.Ebx.CustomMatchSelectFloatEntityData;
		public override string DisplayName => "CustomMatchSelectFloat";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CustomMatchSelectFloatEntity(FrostySdk.Ebx.CustomMatchSelectFloatEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

