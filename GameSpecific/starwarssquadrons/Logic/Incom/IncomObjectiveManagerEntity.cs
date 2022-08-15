using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomObjectiveManagerEntityData))]
	public class IncomObjectiveManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomObjectiveManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomObjectiveManagerEntityData Data => data as FrostySdk.Ebx.IncomObjectiveManagerEntityData;
		public override string DisplayName => "IncomObjectiveManager";

		public IncomObjectiveManagerEntity(FrostySdk.Ebx.IncomObjectiveManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

