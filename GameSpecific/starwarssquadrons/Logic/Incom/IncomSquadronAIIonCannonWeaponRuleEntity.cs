using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIIonCannonWeaponRuleEntityData))]
	public class IncomSquadronAIIonCannonWeaponRuleEntity : IncomSquadronAICannonWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIIonCannonWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIIonCannonWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIIonCannonWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAIIonCannonWeaponRule";

		public IncomSquadronAIIonCannonWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAIIonCannonWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

