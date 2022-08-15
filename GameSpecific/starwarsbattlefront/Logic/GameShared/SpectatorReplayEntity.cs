using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpectatorReplayEntityData))]
	public class SpectatorReplayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpectatorReplayEntityData>
	{
		public new FrostySdk.Ebx.SpectatorReplayEntityData Data => data as FrostySdk.Ebx.SpectatorReplayEntityData;
		public override string DisplayName => "SpectatorReplay";

		public SpectatorReplayEntity(FrostySdk.Ebx.SpectatorReplayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

