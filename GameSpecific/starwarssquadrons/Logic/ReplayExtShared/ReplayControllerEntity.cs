using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ReplayControllerEntityData))]
	public class ReplayControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ReplayControllerEntityData>
	{
		public new FrostySdk.Ebx.ReplayControllerEntityData Data => data as FrostySdk.Ebx.ReplayControllerEntityData;
		public override string DisplayName => "ReplayController";

		public ReplayControllerEntity(FrostySdk.Ebx.ReplayControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

