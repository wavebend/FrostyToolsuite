using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockPickupEntityData))]
	public class UnlockPickupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockPickupEntityData>
	{
		public new FrostySdk.Ebx.UnlockPickupEntityData Data => data as FrostySdk.Ebx.UnlockPickupEntityData;
		public override string DisplayName => "UnlockPickup";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UnlockPickupEntity(FrostySdk.Ebx.UnlockPickupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

