using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InGameEventActionEntityData))]
	public class InGameEventActionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InGameEventActionEntityData>
	{
		public new FrostySdk.Ebx.InGameEventActionEntityData Data => data as FrostySdk.Ebx.InGameEventActionEntityData;
		public override string DisplayName => "InGameEventAction";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public InGameEventActionEntity(FrostySdk.Ebx.InGameEventActionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

