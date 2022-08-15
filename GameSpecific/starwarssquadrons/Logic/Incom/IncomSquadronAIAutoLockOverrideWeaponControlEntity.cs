using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponControlEntityData))]
	public class IncomSquadronAIAutoLockOverrideWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIAutoLockOverrideWeaponControl";

		public IncomSquadronAIAutoLockOverrideWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIAutoLockOverrideWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

