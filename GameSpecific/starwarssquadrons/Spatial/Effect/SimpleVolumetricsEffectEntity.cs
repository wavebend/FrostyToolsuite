using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleVolumetricsEffectEntityData))]
	public class SimpleVolumetricsEffectEntity : ChildEffectEntity, IEntityData<FrostySdk.Ebx.SimpleVolumetricsEffectEntityData>
	{
		public new FrostySdk.Ebx.SimpleVolumetricsEffectEntityData Data => data as FrostySdk.Ebx.SimpleVolumetricsEffectEntityData;

		public SimpleVolumetricsEffectEntity(FrostySdk.Ebx.SimpleVolumetricsEffectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

