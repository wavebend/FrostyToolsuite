using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InGameEventEntityData))]
	public class InGameEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InGameEventEntityData>
	{
		public new FrostySdk.Ebx.InGameEventEntityData Data => data as FrostySdk.Ebx.InGameEventEntityData;
		public override string DisplayName => "InGameEvent";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public InGameEventEntity(FrostySdk.Ebx.InGameEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

