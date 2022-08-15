using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIControllerEntityData))]
	public class IncomSquadronAIControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIControllerEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIControllerEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIControllerEntityData;
		public override string DisplayName => "IncomSquadronAIController";

		public IncomSquadronAIControllerEntity(FrostySdk.Ebx.IncomSquadronAIControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

