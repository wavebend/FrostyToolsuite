using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretBalanceEntityData))]
	public class TurretBalanceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TurretBalanceEntityData>
	{
		public new FrostySdk.Ebx.TurretBalanceEntityData Data => data as FrostySdk.Ebx.TurretBalanceEntityData;
		public override string DisplayName => "TurretBalance";

		public TurretBalanceEntity(FrostySdk.Ebx.TurretBalanceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

