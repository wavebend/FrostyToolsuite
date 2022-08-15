using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBombsWeaponRuleEntityData))]
	public class IncomSquadronAIBombsWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBombsWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBombsWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBombsWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIBombsWeaponRule";

		public IncomSquadronAIBombsWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIBombsWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

