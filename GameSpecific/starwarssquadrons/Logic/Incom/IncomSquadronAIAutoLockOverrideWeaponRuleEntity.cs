using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponRuleEntityData))]
	public class IncomSquadronAIAutoLockOverrideWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIAutoLockOverrideWeaponRule";

		public IncomSquadronAIAutoLockOverrideWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

