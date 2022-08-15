using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IsConfigEquippedOnShipData))]
	public class IsConfigEquippedOnShip : LogicEntity, IEntityData<FrostySdk.Ebx.IsConfigEquippedOnShipData>
	{
		public new FrostySdk.Ebx.IsConfigEquippedOnShipData Data => data as FrostySdk.Ebx.IsConfigEquippedOnShipData;
		public override string DisplayName => "IsConfigEquippedOnShip";

		public IsConfigEquippedOnShip(FrostySdk.Ebx.IsConfigEquippedOnShipData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

