using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementTextInputEntityData))]
	public class WSUIElementTextInputEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.WSUIElementTextInputEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementTextInputEntityData Data => data as FrostySdk.Ebx.WSUIElementTextInputEntityData;
		public override string DisplayName => "WSUIElementTextInput";

		public WSUIElementTextInputEntity(FrostySdk.Ebx.WSUIElementTextInputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

