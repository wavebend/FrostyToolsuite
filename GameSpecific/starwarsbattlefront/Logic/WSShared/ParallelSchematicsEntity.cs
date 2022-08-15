using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ParallelSchematicsEntityData))]
	public class ParallelSchematicsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ParallelSchematicsEntityData>
	{
		public new FrostySdk.Ebx.ParallelSchematicsEntityData Data => data as FrostySdk.Ebx.ParallelSchematicsEntityData;
		public override string DisplayName => "ParallelSchematics";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ParallelSchematicsEntity(FrostySdk.Ebx.ParallelSchematicsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

