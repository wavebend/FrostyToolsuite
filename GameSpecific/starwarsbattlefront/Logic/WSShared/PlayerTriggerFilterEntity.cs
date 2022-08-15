using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerTriggerFilterEntityData))]
	public class PlayerTriggerFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerTriggerFilterEntityData>
	{
		public new FrostySdk.Ebx.PlayerTriggerFilterEntityData Data => data as FrostySdk.Ebx.PlayerTriggerFilterEntityData;
		public override string DisplayName => "PlayerTriggerFilter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerTriggerFilterEntity(FrostySdk.Ebx.PlayerTriggerFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

