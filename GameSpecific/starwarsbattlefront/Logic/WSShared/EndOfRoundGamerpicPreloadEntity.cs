using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EndOfRoundGamerpicPreloadEntityData))]
	public class EndOfRoundGamerpicPreloadEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EndOfRoundGamerpicPreloadEntityData>
	{
		public new FrostySdk.Ebx.EndOfRoundGamerpicPreloadEntityData Data => data as FrostySdk.Ebx.EndOfRoundGamerpicPreloadEntityData;
		public override string DisplayName => "EndOfRoundGamerpicPreload";

		public EndOfRoundGamerpicPreloadEntity(FrostySdk.Ebx.EndOfRoundGamerpicPreloadEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

