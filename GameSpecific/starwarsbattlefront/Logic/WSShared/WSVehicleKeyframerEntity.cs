using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVehicleKeyframerEntityData))]
	public class WSVehicleKeyframerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WSVehicleKeyframerEntityData>
	{
		public new FrostySdk.Ebx.WSVehicleKeyframerEntityData Data => data as FrostySdk.Ebx.WSVehicleKeyframerEntityData;
		public override string DisplayName => "WSVehicleKeyframer";

		public WSVehicleKeyframerEntity(FrostySdk.Ebx.WSVehicleKeyframerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

