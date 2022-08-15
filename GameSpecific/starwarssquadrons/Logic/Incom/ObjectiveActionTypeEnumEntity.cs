using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectiveActionTypeEnumEntityData))]
	public class ObjectiveActionTypeEnumEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ObjectiveActionTypeEnumEntityData>
	{
		public new FrostySdk.Ebx.ObjectiveActionTypeEnumEntityData Data => data as FrostySdk.Ebx.ObjectiveActionTypeEnumEntityData;
		public override string DisplayName => "ObjectiveActionTypeEnum";

		public ObjectiveActionTypeEnumEntity(FrostySdk.Ebx.ObjectiveActionTypeEnumEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

