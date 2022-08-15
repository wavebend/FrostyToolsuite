using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementVideoEntityData))]
	public class WSUIElementVideoEntity : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementVideoEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementVideoEntityData Data => data as FrostySdk.Ebx.WSUIElementVideoEntityData;
		public override string DisplayName => "WSUIElementVideo";

		public WSUIElementVideoEntity(FrostySdk.Ebx.WSUIElementVideoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

