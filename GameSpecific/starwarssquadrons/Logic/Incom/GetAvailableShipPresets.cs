using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetAvailableShipPresetsData))]
	public class GetAvailableShipPresets : LogicEntity, IEntityData<FrostySdk.Ebx.GetAvailableShipPresetsData>
	{
		public new FrostySdk.Ebx.GetAvailableShipPresetsData Data => data as FrostySdk.Ebx.GetAvailableShipPresetsData;
		public override string DisplayName => "GetAvailableShipPresets";

		public GetAvailableShipPresets(FrostySdk.Ebx.GetAvailableShipPresetsData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

