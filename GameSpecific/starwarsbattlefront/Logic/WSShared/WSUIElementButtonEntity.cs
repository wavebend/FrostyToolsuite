using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementButtonEntityData))]
	public class WSUIElementButtonEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.WSUIElementButtonEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementButtonEntityData Data => data as FrostySdk.Ebx.WSUIElementButtonEntityData;
		public override string DisplayName => "WSUIElementButton";

		public WSUIElementButtonEntity(FrostySdk.Ebx.WSUIElementButtonEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

