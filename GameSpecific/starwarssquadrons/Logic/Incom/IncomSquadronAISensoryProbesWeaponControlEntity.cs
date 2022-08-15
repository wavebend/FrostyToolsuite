using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponControlEntityData))]
	public class IncomSquadronAISensoryProbesWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAISensoryProbesWeaponControl";

		public IncomSquadronAISensoryProbesWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAISensoryProbesWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

