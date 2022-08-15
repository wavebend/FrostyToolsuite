using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIAIMarkerHelperEntityData))]
	public class IncomUIAIMarkerHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIAIMarkerHelperEntityData>
	{
		public new FrostySdk.Ebx.IncomUIAIMarkerHelperEntityData Data => data as FrostySdk.Ebx.IncomUIAIMarkerHelperEntityData;
		public override string DisplayName => "IncomUIAIMarkerHelper";

		public IncomUIAIMarkerHelperEntity(FrostySdk.Ebx.IncomUIAIMarkerHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

