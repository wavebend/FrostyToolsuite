using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetPresenceStatusData))]
	public class GetPresenceStatus : LogicEntity, IEntityData<FrostySdk.Ebx.GetPresenceStatusData>
	{
		public new FrostySdk.Ebx.GetPresenceStatusData Data => data as FrostySdk.Ebx.GetPresenceStatusData;
		public override string DisplayName => "GetPresenceStatus";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public GetPresenceStatus(FrostySdk.Ebx.GetPresenceStatusData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

