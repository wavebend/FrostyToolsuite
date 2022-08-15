using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleHeightEntityData))]
	public class VehicleHeightEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VehicleHeightEntityData>
	{
		public new FrostySdk.Ebx.VehicleHeightEntityData Data => data as FrostySdk.Ebx.VehicleHeightEntityData;
		public override string DisplayName => "VehicleHeight";

		public VehicleHeightEntity(FrostySdk.Ebx.VehicleHeightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

