using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementGamerpicEntityData))]
	public class WSUIElementGamerpicEntity : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.WSUIElementGamerpicEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementGamerpicEntityData Data => data as FrostySdk.Ebx.WSUIElementGamerpicEntityData;
		public override string DisplayName => "WSUIElementGamerpic";

		public WSUIElementGamerpicEntity(FrostySdk.Ebx.WSUIElementGamerpicEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

