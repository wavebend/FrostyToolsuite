using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICannonWeaponControlEntityData))]
	public class IncomSquadronAICannonWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICannonWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICannonWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICannonWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAICannonWeaponControl";

		public IncomSquadronAICannonWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAICannonWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

