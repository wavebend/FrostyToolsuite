using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StatsAwardMetaDataEntityData))]
	public class StatsAwardMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StatsAwardMetaDataEntityData>
	{
		public new FrostySdk.Ebx.StatsAwardMetaDataEntityData Data => data as FrostySdk.Ebx.StatsAwardMetaDataEntityData;
		public override string DisplayName => "StatsAwardMetaData";

		public StatsAwardMetaDataEntity(FrostySdk.Ebx.StatsAwardMetaDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

