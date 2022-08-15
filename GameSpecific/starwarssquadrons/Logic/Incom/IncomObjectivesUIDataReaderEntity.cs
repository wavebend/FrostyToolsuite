using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomObjectivesUIDataReaderEntityData))]
	public class IncomObjectivesUIDataReaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomObjectivesUIDataReaderEntityData>
	{
		public new FrostySdk.Ebx.IncomObjectivesUIDataReaderEntityData Data => data as FrostySdk.Ebx.IncomObjectivesUIDataReaderEntityData;
		public override string DisplayName => "IncomObjectivesUIDataReader";

		public IncomObjectivesUIDataReaderEntity(FrostySdk.Ebx.IncomObjectivesUIDataReaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

