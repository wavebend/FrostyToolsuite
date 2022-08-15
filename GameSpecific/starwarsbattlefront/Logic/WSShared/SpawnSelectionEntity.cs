using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpawnSelectionEntityData))]
	public class SpawnSelectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpawnSelectionEntityData>
	{
		public new FrostySdk.Ebx.SpawnSelectionEntityData Data => data as FrostySdk.Ebx.SpawnSelectionEntityData;
		public override string DisplayName => "SpawnSelection";

		public SpawnSelectionEntity(FrostySdk.Ebx.SpawnSelectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

