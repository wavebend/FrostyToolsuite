using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CleanupEntityData))]
	public class CleanupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CleanupEntityData>
	{
		public new FrostySdk.Ebx.CleanupEntityData Data => data as FrostySdk.Ebx.CleanupEntityData;
		public override string DisplayName => "Cleanup";

		public CleanupEntity(FrostySdk.Ebx.CleanupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

