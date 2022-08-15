using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CombatAreaSpeedControlEntityData))]
	public class CombatAreaSpeedControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CombatAreaSpeedControlEntityData>
	{
		public new FrostySdk.Ebx.CombatAreaSpeedControlEntityData Data => data as FrostySdk.Ebx.CombatAreaSpeedControlEntityData;
		public override string DisplayName => "CombatAreaSpeedControl";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CombatAreaSpeedControlEntity(FrostySdk.Ebx.CombatAreaSpeedControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

