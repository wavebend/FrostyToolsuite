using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetShipStatsToDisplayData))]
	public class GetShipStatsToDisplay : LogicEntity, IEntityData<FrostySdk.Ebx.GetShipStatsToDisplayData>
	{
		public new FrostySdk.Ebx.GetShipStatsToDisplayData Data => data as FrostySdk.Ebx.GetShipStatsToDisplayData;
		public override string DisplayName => "GetShipStatsToDisplay";

		public GetShipStatsToDisplay(FrostySdk.Ebx.GetShipStatsToDisplayData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

