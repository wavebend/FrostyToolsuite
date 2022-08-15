using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HologramProjectorEntityData))]
	public class HologramProjectorEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.HologramProjectorEntityData>
	{
		public new FrostySdk.Ebx.HologramProjectorEntityData Data => data as FrostySdk.Ebx.HologramProjectorEntityData;

		public HologramProjectorEntity(FrostySdk.Ebx.HologramProjectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

