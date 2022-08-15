using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameRegionEntityData))]
	public class GameRegionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GameRegionEntityData>
	{
		public new FrostySdk.Ebx.GameRegionEntityData Data => data as FrostySdk.Ebx.GameRegionEntityData;
		public override string DisplayName => "GameRegion";

		public GameRegionEntity(FrostySdk.Ebx.GameRegionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

