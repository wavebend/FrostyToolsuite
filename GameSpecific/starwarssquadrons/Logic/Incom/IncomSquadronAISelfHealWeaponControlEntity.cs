using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISelfHealWeaponControlEntityData))]
	public class IncomSquadronAISelfHealWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISelfHealWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISelfHealWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISelfHealWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAISelfHealWeaponControl";

		public IncomSquadronAISelfHealWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAISelfHealWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

