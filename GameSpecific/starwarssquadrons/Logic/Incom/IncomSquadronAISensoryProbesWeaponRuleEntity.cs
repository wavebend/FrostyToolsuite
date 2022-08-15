using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponRuleEntityData))]
	public class IncomSquadronAISensoryProbesWeaponRuleEntity : IncomSquadronAIWeaponRuleEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponRuleEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponRuleEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponRuleEntityData;
		public override string DisplayName => "IncomSquadronAISensoryProbesWeaponRule";

		public IncomSquadronAISensoryProbesWeaponRuleEntity(FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponRuleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

