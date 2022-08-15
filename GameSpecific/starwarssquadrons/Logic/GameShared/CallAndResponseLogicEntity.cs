using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CallAndResponseLogicEntityData))]
	public class CallAndResponseLogicEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CallAndResponseLogicEntityData>
	{
		public new FrostySdk.Ebx.CallAndResponseLogicEntityData Data => data as FrostySdk.Ebx.CallAndResponseLogicEntityData;
		public override string DisplayName => "CallAndResponseLogic";

		public CallAndResponseLogicEntity(FrostySdk.Ebx.CallAndResponseLogicEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

