using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIMissileWeaponControlEntityData))]
	public class IncomSquadronAIMissileWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIMissileWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIMissileWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIMissileWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIMissileWeaponControl";

		public IncomSquadronAIMissileWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIMissileWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

