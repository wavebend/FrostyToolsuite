using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EmitterExclusionVolumeData))]
	public class EmitterExclusionVolume : SpatialEntity, IEntityData<FrostySdk.Ebx.EmitterExclusionVolumeData>
	{
		public new FrostySdk.Ebx.EmitterExclusionVolumeData Data => data as FrostySdk.Ebx.EmitterExclusionVolumeData;

		public EmitterExclusionVolume(FrostySdk.Ebx.EmitterExclusionVolumeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

