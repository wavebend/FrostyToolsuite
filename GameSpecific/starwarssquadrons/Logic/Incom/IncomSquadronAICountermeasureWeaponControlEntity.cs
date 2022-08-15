using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponControlEntityData))]
	public class IncomSquadronAICountermeasureWeaponControlEntity : IncomSquadronAIWeaponControlEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponControlEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponControlEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponControlEntityData;
		public override string DisplayName => "IncomSquadronAICountermeasureWeaponControl";

		public IncomSquadronAICountermeasureWeaponControlEntity(FrostySdk.Ebx.IncomSquadronAICountermeasureWeaponControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

