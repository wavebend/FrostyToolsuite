using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUITargetHighlightEntityData))]
	public class IncomUITargetHighlightEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUITargetHighlightEntityData>
	{
		public new FrostySdk.Ebx.IncomUITargetHighlightEntityData Data => data as FrostySdk.Ebx.IncomUITargetHighlightEntityData;
		public override string DisplayName => "IncomUITargetHighlight";

		public IncomUITargetHighlightEntity(FrostySdk.Ebx.IncomUITargetHighlightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

