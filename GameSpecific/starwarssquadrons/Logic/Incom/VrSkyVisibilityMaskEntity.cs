using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VrSkyVisibilityMaskEntityData))]
	public class VrSkyVisibilityMaskEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VrSkyVisibilityMaskEntityData>
	{
		public new FrostySdk.Ebx.VrSkyVisibilityMaskEntityData Data => data as FrostySdk.Ebx.VrSkyVisibilityMaskEntityData;
		public override string DisplayName => "VrSkyVisibilityMask";

		public VrSkyVisibilityMaskEntity(FrostySdk.Ebx.VrSkyVisibilityMaskEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

