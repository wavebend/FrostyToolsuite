using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StaticTextureEntityData))]
	public class StaticTextureEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StaticTextureEntityData>
	{
		public new FrostySdk.Ebx.StaticTextureEntityData Data => data as FrostySdk.Ebx.StaticTextureEntityData;
		public override string DisplayName => "StaticTexture";

		public StaticTextureEntity(FrostySdk.Ebx.StaticTextureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

