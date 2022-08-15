using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.KeyBindingsFilterEntityData))]
	public class KeyBindingsFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.KeyBindingsFilterEntityData>
	{
		public new FrostySdk.Ebx.KeyBindingsFilterEntityData Data => data as FrostySdk.Ebx.KeyBindingsFilterEntityData;
		public override string DisplayName => "KeyBindingsFilter";

		public KeyBindingsFilterEntity(FrostySdk.Ebx.KeyBindingsFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

