using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementInputConceptIconEntityData))]
	public class WSUIElementInputConceptIconEntity : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementInputConceptIconEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementInputConceptIconEntityData Data => data as FrostySdk.Ebx.WSUIElementInputConceptIconEntityData;
		public override string DisplayName => "WSUIElementInputConceptIcon";

		public WSUIElementInputConceptIconEntity(FrostySdk.Ebx.WSUIElementInputConceptIconEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

