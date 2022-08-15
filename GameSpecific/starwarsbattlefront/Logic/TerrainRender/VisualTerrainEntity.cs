using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VisualTerrainEntityData))]
	public class VisualTerrainEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VisualTerrainEntityData>
	{
		public new FrostySdk.Ebx.VisualTerrainEntityData Data => data as FrostySdk.Ebx.VisualTerrainEntityData;
		public override string DisplayName => "VisualTerrain";

		public VisualTerrainEntity(FrostySdk.Ebx.VisualTerrainEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

