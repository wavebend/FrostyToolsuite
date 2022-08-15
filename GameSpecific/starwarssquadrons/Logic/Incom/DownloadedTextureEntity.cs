using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DownloadedTextureEntityData))]
	public class DownloadedTextureEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DownloadedTextureEntityData>
	{
		public new FrostySdk.Ebx.DownloadedTextureEntityData Data => data as FrostySdk.Ebx.DownloadedTextureEntityData;
		public override string DisplayName => "DownloadedTexture";

		public DownloadedTextureEntity(FrostySdk.Ebx.DownloadedTextureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

