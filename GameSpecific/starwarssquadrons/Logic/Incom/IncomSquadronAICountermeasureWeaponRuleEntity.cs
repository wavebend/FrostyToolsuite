using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponRuleEntityData))]
	public class IncomSquadronAICountermeasureWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAICountermeasureWeaponRule";

		public IncomSquadronAICountermeasureWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

