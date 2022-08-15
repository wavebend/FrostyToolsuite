using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIManagerEntityData))]
	public class IncomSquadronAIManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIManagerEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIManagerEntityData;
		public override string DisplayName => "IncomSquadronAIManager";

		public IncomSquadronAIManagerEntity(FrostySdk.Ebx.IncomSquadronAIManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

