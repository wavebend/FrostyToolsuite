using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIBombsWeaponControlEntityData))]
	public class IncomSquadronAIBombsWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIBombsWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIBombsWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIBombsWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIBombsWeaponControl";

		public IncomSquadronAIBombsWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIBombsWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

