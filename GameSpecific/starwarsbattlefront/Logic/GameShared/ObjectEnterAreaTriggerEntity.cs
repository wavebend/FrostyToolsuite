using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectEnterAreaTriggerEntityData))]
	public class ObjectEnterAreaTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ObjectEnterAreaTriggerEntityData>
	{
		public new FrostySdk.Ebx.ObjectEnterAreaTriggerEntityData Data => data as FrostySdk.Ebx.ObjectEnterAreaTriggerEntityData;
		public override string DisplayName => "ObjectEnterAreaTrigger";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ObjectEnterAreaTriggerEntity(FrostySdk.Ebx.ObjectEnterAreaTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

