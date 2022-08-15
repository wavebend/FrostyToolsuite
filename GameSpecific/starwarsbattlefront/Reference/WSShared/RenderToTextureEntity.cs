using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RenderToTextureEntityData))]
	public class RenderToTextureEntity : LogicReferenceObject, IEntityData<FrostySdk.Ebx.RenderToTextureEntityData>
	{
		public new FrostySdk.Ebx.RenderToTextureEntityData Data => data as FrostySdk.Ebx.RenderToTextureEntityData;

		public RenderToTextureEntity(FrostySdk.Ebx.RenderToTextureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

