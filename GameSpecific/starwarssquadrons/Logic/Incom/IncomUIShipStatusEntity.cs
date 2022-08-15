using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIShipStatusEntityData))]
	public class IncomUIShipStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIShipStatusEntityData>
	{
		public new FrostySdk.Ebx.IncomUIShipStatusEntityData Data => data as FrostySdk.Ebx.IncomUIShipStatusEntityData;
		public override string DisplayName => "IncomUIShipStatus";

		public IncomUIShipStatusEntity(FrostySdk.Ebx.IncomUIShipStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

