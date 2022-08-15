using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIWeaponControlEntityData))]
	public class IncomSquadronAIWeaponControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIWeaponControl";

		public IncomSquadronAIWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

