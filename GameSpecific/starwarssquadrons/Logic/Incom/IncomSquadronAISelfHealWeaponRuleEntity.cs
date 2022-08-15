using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISelfHealWeaponRuleEntityData))]
	public class IncomSquadronAISelfHealWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISelfHealWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISelfHealWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISelfHealWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAISelfHealWeaponRule";

		public IncomSquadronAISelfHealWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAISelfHealWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

