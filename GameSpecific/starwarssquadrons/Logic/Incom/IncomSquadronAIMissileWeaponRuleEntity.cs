using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIMissileWeaponRuleEntityData))]
	public class IncomSquadronAIMissileWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIMissileWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIMissileWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIMissileWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIMissileWeaponRule";

		public IncomSquadronAIMissileWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIMissileWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

