using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementScrollBarEntityData))]
	public class WSUIElementScrollBarEntity : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementScrollBarEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementScrollBarEntityData Data => data as FrostySdk.Ebx.WSUIElementScrollBarEntityData;
		public override string DisplayName => "WSUIElementScrollBar";

		public WSUIElementScrollBarEntity(FrostySdk.Ebx.WSUIElementScrollBarEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

