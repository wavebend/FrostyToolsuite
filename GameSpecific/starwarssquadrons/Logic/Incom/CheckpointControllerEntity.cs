using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CheckpointControllerEntityData))]
	public class CheckpointControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CheckpointControllerEntityData>
	{
		public new FrostySdk.Ebx.CheckpointControllerEntityData Data => data as FrostySdk.Ebx.CheckpointControllerEntityData;
		public override string DisplayName => "CheckpointController";

		public CheckpointControllerEntity(FrostySdk.Ebx.CheckpointControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

