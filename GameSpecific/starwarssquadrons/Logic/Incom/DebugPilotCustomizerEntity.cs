using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugPilotCustomizerEntityData))]
	public class DebugPilotCustomizerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugPilotCustomizerEntityData>
	{
		public new FrostySdk.Ebx.DebugPilotCustomizerEntityData Data => data as FrostySdk.Ebx.DebugPilotCustomizerEntityData;
		public override string DisplayName => "DebugPilotCustomizer";

		public DebugPilotCustomizerEntity(FrostySdk.Ebx.DebugPilotCustomizerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

