using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarsCompletedEntityData))]
	public class StarsCompletedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarsCompletedEntityData>
	{
		public new FrostySdk.Ebx.StarsCompletedEntityData Data => data as FrostySdk.Ebx.StarsCompletedEntityData;
		public override string DisplayName => "StarsCompleted";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public StarsCompletedEntity(FrostySdk.Ebx.StarsCompletedEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

