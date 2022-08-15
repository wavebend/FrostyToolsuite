using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EnlightenEntityProxyData))]
	public class EnlightenEntityProxy : SpatialEntity, IEntityData<FrostySdk.Ebx.EnlightenEntityProxyData>
	{
		public new FrostySdk.Ebx.EnlightenEntityProxyData Data => data as FrostySdk.Ebx.EnlightenEntityProxyData;

		public EnlightenEntityProxy(FrostySdk.Ebx.EnlightenEntityProxyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

