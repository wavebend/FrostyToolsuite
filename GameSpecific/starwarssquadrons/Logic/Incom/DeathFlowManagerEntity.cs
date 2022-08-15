using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeathFlowManagerEntityData))]
	public class DeathFlowManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeathFlowManagerEntityData>
	{
		public new FrostySdk.Ebx.DeathFlowManagerEntityData Data => data as FrostySdk.Ebx.DeathFlowManagerEntityData;
		public override string DisplayName => "DeathFlowManager";

		public DeathFlowManagerEntity(FrostySdk.Ebx.DeathFlowManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

