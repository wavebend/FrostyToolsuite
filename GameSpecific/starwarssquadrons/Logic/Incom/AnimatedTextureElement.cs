using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AnimatedTextureElementData))]
	public class AnimatedTextureElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.AnimatedTextureElementData>
	{
		public new FrostySdk.Ebx.AnimatedTextureElementData Data => data as FrostySdk.Ebx.AnimatedTextureElementData;
		public override string DisplayName => "AnimatedTextureElement";

		public AnimatedTextureElement(FrostySdk.Ebx.AnimatedTextureElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

