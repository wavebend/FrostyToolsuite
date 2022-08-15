using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleWeaponSyncEntityData))]
	public class SimpleWeaponSyncEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SimpleWeaponSyncEntityData>
	{
		public new FrostySdk.Ebx.SimpleWeaponSyncEntityData Data => data as FrostySdk.Ebx.SimpleWeaponSyncEntityData;
		public override string DisplayName => "SimpleWeaponSync";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SimpleWeaponSyncEntity(FrostySdk.Ebx.SimpleWeaponSyncEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

