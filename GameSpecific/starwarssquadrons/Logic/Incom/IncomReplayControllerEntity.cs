using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomReplayControllerEntityData))]
	public class IncomReplayControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomReplayControllerEntityData>
	{
		public new FrostySdk.Ebx.IncomReplayControllerEntityData Data => data as FrostySdk.Ebx.IncomReplayControllerEntityData;
		public override string DisplayName => "IncomReplayController";

		public IncomReplayControllerEntity(FrostySdk.Ebx.IncomReplayControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

