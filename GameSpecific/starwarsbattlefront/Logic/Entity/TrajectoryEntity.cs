using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TrajectoryEntityData))]
	public class TrajectoryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TrajectoryEntityData>
	{
		public new FrostySdk.Ebx.TrajectoryEntityData Data => data as FrostySdk.Ebx.TrajectoryEntityData;
		public override string DisplayName => "Trajectory";

		public TrajectoryEntity(FrostySdk.Ebx.TrajectoryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

