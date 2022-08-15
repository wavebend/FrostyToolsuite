using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardBoostChargePickupEntityData))]
	public class ForceCardBoostChargePickupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardBoostChargePickupEntityData>
	{
		public new FrostySdk.Ebx.ForceCardBoostChargePickupEntityData Data => data as FrostySdk.Ebx.ForceCardBoostChargePickupEntityData;
		public override string DisplayName => "ForceCardBoostChargePickup";

		public ForceCardBoostChargePickupEntity(FrostySdk.Ebx.ForceCardBoostChargePickupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

