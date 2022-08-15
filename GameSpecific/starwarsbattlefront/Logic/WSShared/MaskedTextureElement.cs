using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaskedTextureElementData))]
	public class MaskedTextureElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.MaskedTextureElementData>
	{
		public new FrostySdk.Ebx.MaskedTextureElementData Data => data as FrostySdk.Ebx.MaskedTextureElementData;
		public override string DisplayName => "MaskedTextureElement";

		public MaskedTextureElement(FrostySdk.Ebx.MaskedTextureElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

