using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EntityCinebitAttachableEntityData))]
	public class EntityCinebitAttachableEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EntityCinebitAttachableEntityData>
	{
		public new FrostySdk.Ebx.EntityCinebitAttachableEntityData Data => data as FrostySdk.Ebx.EntityCinebitAttachableEntityData;
		public override string DisplayName => "EntityCinebitAttachable";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public EntityCinebitAttachableEntity(FrostySdk.Ebx.EntityCinebitAttachableEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

