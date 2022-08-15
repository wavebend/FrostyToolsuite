using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUICombatDisplayEntityData))]
	public class IncomUICombatDisplayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUICombatDisplayEntityData>
	{
		public new FrostySdk.Ebx.IncomUICombatDisplayEntityData Data => data as FrostySdk.Ebx.IncomUICombatDisplayEntityData;
		public override string DisplayName => "IncomUICombatDisplay";

		public IncomUICombatDisplayEntity(FrostySdk.Ebx.IncomUICombatDisplayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

