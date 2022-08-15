using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchSelectIntEntityData))]
	public class CustomMatchSelectIntEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchSelectIntEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchSelectIntEntityData Data => data as FrostySdk.Ebx.CustomMatchSelectIntEntityData;
		public override string DisplayName => "CustomMatchSelectInt";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CustomMatchSelectIntEntity(FrostySdk.Ebx.CustomMatchSelectIntEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

