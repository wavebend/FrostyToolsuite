using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomGameModeSwitchEntityData))]
	public class IncomGameModeSwitchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomGameModeSwitchEntityData>
	{
		public new FrostySdk.Ebx.IncomGameModeSwitchEntityData Data => data as FrostySdk.Ebx.IncomGameModeSwitchEntityData;
		public override string DisplayName => "IncomGameModeSwitch";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomGameModeSwitchEntity(FrostySdk.Ebx.IncomGameModeSwitchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

