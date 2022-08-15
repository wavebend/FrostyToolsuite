using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIDogfighterInfoEntityData))]
	public class IncomSquadronAIDogfighterInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIDogfighterInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIDogfighterInfoEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIDogfighterInfoEntityData;
		public override string DisplayName => "IncomSquadronAIDogfighterInfo";

		public IncomSquadronAIDogfighterInfoEntity(FrostySdk.Ebx.IncomSquadronAIDogfighterInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

