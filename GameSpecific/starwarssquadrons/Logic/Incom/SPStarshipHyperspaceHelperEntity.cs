using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SPStarshipHyperspaceHelperEntityData))]
	public class SPStarshipHyperspaceHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SPStarshipHyperspaceHelperEntityData>
	{
		public new FrostySdk.Ebx.SPStarshipHyperspaceHelperEntityData Data => data as FrostySdk.Ebx.SPStarshipHyperspaceHelperEntityData;
		public override string DisplayName => "SPStarshipHyperspaceHelper";

		public SPStarshipHyperspaceHelperEntity(FrostySdk.Ebx.SPStarshipHyperspaceHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

