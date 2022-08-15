using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.KillSwitchEntityData))]
	public class KillSwitchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.KillSwitchEntityData>
	{
		public new FrostySdk.Ebx.KillSwitchEntityData Data => data as FrostySdk.Ebx.KillSwitchEntityData;
		public override string DisplayName => "KillSwitch";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public KillSwitchEntity(FrostySdk.Ebx.KillSwitchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

