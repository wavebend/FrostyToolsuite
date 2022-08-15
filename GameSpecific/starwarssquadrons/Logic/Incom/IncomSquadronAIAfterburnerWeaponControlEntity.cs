using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponControlEntityData))]
	public class IncomSquadronAIAfterburnerWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIAfterburnerWeaponControl";

		public IncomSquadronAIAfterburnerWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIAfterburnerWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

