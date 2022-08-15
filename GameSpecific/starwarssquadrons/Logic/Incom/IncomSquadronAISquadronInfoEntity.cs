using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISquadronInfoEntityData))]
	public class IncomSquadronAISquadronInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISquadronInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISquadronInfoEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISquadronInfoEntityData;
		public override string DisplayName => "IncomSquadronAISquadronInfo";

		public IncomSquadronAISquadronInfoEntity(FrostySdk.Ebx.IncomSquadronAISquadronInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

