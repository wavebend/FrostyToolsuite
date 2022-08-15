using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoipAccessibilityEntityData))]
	public class VoipAccessibilityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoipAccessibilityEntityData>
	{
		public new FrostySdk.Ebx.VoipAccessibilityEntityData Data => data as FrostySdk.Ebx.VoipAccessibilityEntityData;
		public override string DisplayName => "VoipAccessibility";

		public VoipAccessibilityEntity(FrostySdk.Ebx.VoipAccessibilityEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

