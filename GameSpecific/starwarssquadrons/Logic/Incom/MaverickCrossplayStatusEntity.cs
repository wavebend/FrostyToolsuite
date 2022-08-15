using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaverickCrossplayStatusEntityData))]
	public class MaverickCrossplayStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MaverickCrossplayStatusEntityData>
	{
		public new FrostySdk.Ebx.MaverickCrossplayStatusEntityData Data => data as FrostySdk.Ebx.MaverickCrossplayStatusEntityData;
		public override string DisplayName => "MaverickCrossplayStatus";

		public MaverickCrossplayStatusEntity(FrostySdk.Ebx.MaverickCrossplayStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

