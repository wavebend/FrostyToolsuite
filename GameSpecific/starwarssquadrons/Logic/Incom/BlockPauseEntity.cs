using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BlockPauseEntityData))]
	public class BlockPauseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BlockPauseEntityData>
	{
		public new FrostySdk.Ebx.BlockPauseEntityData Data => data as FrostySdk.Ebx.BlockPauseEntityData;
		public override string DisplayName => "BlockPause";

		public BlockPauseEntity(FrostySdk.Ebx.BlockPauseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

