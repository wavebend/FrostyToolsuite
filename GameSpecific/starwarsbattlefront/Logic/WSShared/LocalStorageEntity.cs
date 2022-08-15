using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LocalStorageEntityData))]
	public class LocalStorageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LocalStorageEntityData>
	{
		public new FrostySdk.Ebx.LocalStorageEntityData Data => data as FrostySdk.Ebx.LocalStorageEntityData;
		public override string DisplayName => "LocalStorage";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LocalStorageEntity(FrostySdk.Ebx.LocalStorageEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

