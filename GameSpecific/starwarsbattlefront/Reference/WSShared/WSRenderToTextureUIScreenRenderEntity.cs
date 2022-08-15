using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSRenderToTextureUIScreenRenderEntityData))]
	public class WSRenderToTextureUIScreenRenderEntity : WSUIScreenRenderEntity, IEntityData<FrostySdk.Ebx.WSRenderToTextureUIScreenRenderEntityData>
	{
		public new FrostySdk.Ebx.WSRenderToTextureUIScreenRenderEntityData Data => data as FrostySdk.Ebx.WSRenderToTextureUIScreenRenderEntityData;

		public WSRenderToTextureUIScreenRenderEntity(FrostySdk.Ebx.WSRenderToTextureUIScreenRenderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

