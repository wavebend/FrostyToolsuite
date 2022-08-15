using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICannonWeaponRuleEntityData))]
	public class IncomSquadronAICannonWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICannonWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICannonWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICannonWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAICannonWeaponRule";

		public IncomSquadronAICannonWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAICannonWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

