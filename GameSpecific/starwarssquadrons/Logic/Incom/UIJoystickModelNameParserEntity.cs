using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIJoystickModelNameParserEntityData))]
	public class UIJoystickModelNameParserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIJoystickModelNameParserEntityData>
	{
		public new FrostySdk.Ebx.UIJoystickModelNameParserEntityData Data => data as FrostySdk.Ebx.UIJoystickModelNameParserEntityData;
		public override string DisplayName => "UIJoystickModelNameParser";

		public UIJoystickModelNameParserEntity(FrostySdk.Ebx.UIJoystickModelNameParserEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

