using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCombatAreaEntityData))]
	public class IncomCombatAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomCombatAreaEntityData>
	{
		public new FrostySdk.Ebx.IncomCombatAreaEntityData Data => data as FrostySdk.Ebx.IncomCombatAreaEntityData;
		public override string DisplayName => "IncomCombatArea";

		public IncomCombatAreaEntity(FrostySdk.Ebx.IncomCombatAreaEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

