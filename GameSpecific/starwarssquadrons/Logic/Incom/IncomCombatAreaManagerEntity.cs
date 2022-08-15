using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCombatAreaManagerEntityData))]
	public class IncomCombatAreaManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomCombatAreaManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomCombatAreaManagerEntityData Data => data as FrostySdk.Ebx.IncomCombatAreaManagerEntityData;
		public override string DisplayName => "IncomCombatAreaManager";

		public IncomCombatAreaManagerEntity(FrostySdk.Ebx.IncomCombatAreaManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

