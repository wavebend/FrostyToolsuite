using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceAreaTriggerEntityData))]
	public class ForceAreaTriggerEntity : GeometryTriggerEntity, IEntityData<FrostySdk.Ebx.ForceAreaTriggerEntityData>
	{
		public new FrostySdk.Ebx.ForceAreaTriggerEntityData Data => data as FrostySdk.Ebx.ForceAreaTriggerEntityData;

		public ForceAreaTriggerEntity(FrostySdk.Ebx.ForceAreaTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

