using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIActionEntityData))]
	public class AIActionEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.AIActionEntityData>
	{
		public new FrostySdk.Ebx.AIActionEntityData Data => data as FrostySdk.Ebx.AIActionEntityData;

		public AIActionEntity(FrostySdk.Ebx.AIActionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

