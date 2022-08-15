using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OnlinePresenceStateEntityData))]
	public class OnlinePresenceStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OnlinePresenceStateEntityData>
	{
		public new FrostySdk.Ebx.OnlinePresenceStateEntityData Data => data as FrostySdk.Ebx.OnlinePresenceStateEntityData;
		public override string DisplayName => "OnlinePresenceState";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public OnlinePresenceStateEntity(FrostySdk.Ebx.OnlinePresenceStateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

