using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomObjectiveStateEntityData))]
	public class IncomObjectiveStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomObjectiveStateEntityData>
	{
		public new FrostySdk.Ebx.IncomObjectiveStateEntityData Data => data as FrostySdk.Ebx.IncomObjectiveStateEntityData;
		public override string DisplayName => "IncomObjectiveState";

		public IncomObjectiveStateEntity(FrostySdk.Ebx.IncomObjectiveStateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

