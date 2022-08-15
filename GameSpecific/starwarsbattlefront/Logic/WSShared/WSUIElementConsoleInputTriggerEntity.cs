using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementConsoleInputTriggerEntityData))]
	public class WSUIElementConsoleInputTriggerEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.WSUIElementConsoleInputTriggerEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementConsoleInputTriggerEntityData Data => data as FrostySdk.Ebx.WSUIElementConsoleInputTriggerEntityData;
		public override string DisplayName => "WSUIElementConsoleInputTrigger";

		public WSUIElementConsoleInputTriggerEntity(FrostySdk.Ebx.WSUIElementConsoleInputTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

