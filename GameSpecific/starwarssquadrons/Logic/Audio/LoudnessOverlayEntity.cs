using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LoudnessOverlayEntityData))]
	public class LoudnessOverlayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LoudnessOverlayEntityData>
	{
		public new FrostySdk.Ebx.LoudnessOverlayEntityData Data => data as FrostySdk.Ebx.LoudnessOverlayEntityData;
		public override string DisplayName => "LoudnessOverlay";

		public LoudnessOverlayEntity(FrostySdk.Ebx.LoudnessOverlayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

