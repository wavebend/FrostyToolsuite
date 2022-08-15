using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LuaScriptedGraphicsElementData))]
	public class LuaScriptedGraphicsElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.LuaScriptedGraphicsElementData>
	{
		public new FrostySdk.Ebx.LuaScriptedGraphicsElementData Data => data as FrostySdk.Ebx.LuaScriptedGraphicsElementData;
		public override string DisplayName => "LuaScriptedGraphicsElement";

		public LuaScriptedGraphicsElement(FrostySdk.Ebx.LuaScriptedGraphicsElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

