using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IndirectCubeMapData))]
	public class IndirectCubeMap : SpatialEntity, IEntityData<FrostySdk.Ebx.IndirectCubeMapData>
	{
		public new FrostySdk.Ebx.IndirectCubeMapData Data => data as FrostySdk.Ebx.IndirectCubeMapData;

		public IndirectCubeMap(FrostySdk.Ebx.IndirectCubeMapData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

