using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIResupplyWeaponControlEntityData))]
	public class IncomSquadronAIResupplyWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIResupplyWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIResupplyWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIResupplyWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAIResupplyWeaponControl";

		public IncomSquadronAIResupplyWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAIResupplyWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

