using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineCapShipStatusEntityData))]
	public class FrontlineCapShipStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontlineCapShipStatusEntityData>
	{
		public new FrostySdk.Ebx.FrontlineCapShipStatusEntityData Data => data as FrostySdk.Ebx.FrontlineCapShipStatusEntityData;
		public override string DisplayName => "FrontlineCapShipStatus";

		public FrontlineCapShipStatusEntity(FrostySdk.Ebx.FrontlineCapShipStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

