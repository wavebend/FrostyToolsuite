using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MeshVariationOutputEntityData))]
	public class MeshVariationOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MeshVariationOutputEntityData>
	{
		public new FrostySdk.Ebx.MeshVariationOutputEntityData Data => data as FrostySdk.Ebx.MeshVariationOutputEntityData;
		public override string DisplayName => "MeshVariationOutput";

		public MeshVariationOutputEntity(FrostySdk.Ebx.MeshVariationOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

