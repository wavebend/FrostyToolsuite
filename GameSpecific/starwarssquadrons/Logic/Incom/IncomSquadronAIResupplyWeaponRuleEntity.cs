using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIResupplyWeaponRuleEntityData))]
	public class IncomSquadronAIResupplyWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIResupplyWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIResupplyWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIResupplyWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIResupplyWeaponRule";

		public IncomSquadronAIResupplyWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIResupplyWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

