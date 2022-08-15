using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IsMatchAbandonedEntityData))]
	public class IsMatchAbandonedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IsMatchAbandonedEntityData>
	{
		public new FrostySdk.Ebx.IsMatchAbandonedEntityData Data => data as FrostySdk.Ebx.IsMatchAbandonedEntityData;
		public override string DisplayName => "IsMatchAbandoned";

		public IsMatchAbandonedEntity(FrostySdk.Ebx.IsMatchAbandonedEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

