using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomDifficultyManagerData))]
	public class IncomDifficultyManager : LogicEntity, IEntityData<FrostySdk.Ebx.IncomDifficultyManagerData>
	{
		public new FrostySdk.Ebx.IncomDifficultyManagerData Data => data as FrostySdk.Ebx.IncomDifficultyManagerData;
		public override string DisplayName => "IncomDifficultyManager";

		public IncomDifficultyManager(FrostySdk.Ebx.IncomDifficultyManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

