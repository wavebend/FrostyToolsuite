using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetEquippedComponentsForShipData))]
	public class GetEquippedComponentsForShip : LogicEntity, IEntityData<FrostySdk.Ebx.GetEquippedComponentsForShipData>
	{
		public new FrostySdk.Ebx.GetEquippedComponentsForShipData Data => data as FrostySdk.Ebx.GetEquippedComponentsForShipData;
		public override string DisplayName => "GetEquippedComponentsForShip";

		public GetEquippedComponentsForShip(FrostySdk.Ebx.GetEquippedComponentsForShipData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

