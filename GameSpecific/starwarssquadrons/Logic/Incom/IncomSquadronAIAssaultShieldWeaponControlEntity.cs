using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponControlEntityData))]
	public class IncomSquadronAIAssaultShieldWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIAssaultShieldWeaponControl";

		public IncomSquadronAIAssaultShieldWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIAssaultShieldWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

