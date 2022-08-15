using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponRuleEntityData))]
	public class IncomSquadronAIAfterburnerWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIAfterburnerWeaponRule";

		public IncomSquadronAIAfterburnerWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

