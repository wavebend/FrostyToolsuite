using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.KeyBindingInfoEntityData))]
	public class KeyBindingInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.KeyBindingInfoEntityData>
	{
		public new FrostySdk.Ebx.KeyBindingInfoEntityData Data => data as FrostySdk.Ebx.KeyBindingInfoEntityData;
		public override string DisplayName => "KeyBindingInfo";

		public KeyBindingInfoEntity(FrostySdk.Ebx.KeyBindingInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

