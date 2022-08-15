using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetConfigStatsToDisplayData))]
	public class GetConfigStatsToDisplay : LogicEntity, IEntityData<FrostySdk.Ebx.GetConfigStatsToDisplayData>
	{
		public new FrostySdk.Ebx.GetConfigStatsToDisplayData Data => data as FrostySdk.Ebx.GetConfigStatsToDisplayData;
		public override string DisplayName => "GetConfigStatsToDisplay";

		public GetConfigStatsToDisplay(FrostySdk.Ebx.GetConfigStatsToDisplayData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

