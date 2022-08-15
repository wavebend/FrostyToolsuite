using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OriginalLocalLightEntityData))]
	public class OriginalLocalLightEntity : LocalLightEntity, IEntityData<FrostySdk.Ebx.OriginalLocalLightEntityData>
	{
		public new FrostySdk.Ebx.OriginalLocalLightEntityData Data => data as FrostySdk.Ebx.OriginalLocalLightEntityData;

		public OriginalLocalLightEntity(FrostySdk.Ebx.OriginalLocalLightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

