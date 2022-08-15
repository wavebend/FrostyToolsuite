using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponRuleEntityData))]
	public class IncomSquadronAIAssaultShieldWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIAssaultShieldWeaponRule";

		public IncomSquadronAIAssaultShieldWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

