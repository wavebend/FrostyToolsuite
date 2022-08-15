using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSFpsDebugEntityData))]
	public class WSFpsDebugEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WSFpsDebugEntityData>
	{
		public new FrostySdk.Ebx.WSFpsDebugEntityData Data => data as FrostySdk.Ebx.WSFpsDebugEntityData;
		public override string DisplayName => "WSFpsDebug";

		public WSFpsDebugEntity(FrostySdk.Ebx.WSFpsDebugEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

