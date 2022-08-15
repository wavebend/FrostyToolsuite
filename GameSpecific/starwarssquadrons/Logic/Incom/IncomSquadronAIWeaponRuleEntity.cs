using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIWeaponRuleEntityData))]
	public class IncomSquadronAIWeaponRuleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIWeaponRule";

		public IncomSquadronAIWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

