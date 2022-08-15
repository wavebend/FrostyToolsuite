using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitBoxIBLEntityData))]
	public class CockpitBoxIBLEntity : PbrGenericBoxReflectionVolumeEntity, IEntityData<FrostySdk.Ebx.CockpitBoxIBLEntityData>
	{
		public new FrostySdk.Ebx.CockpitBoxIBLEntityData Data => data as FrostySdk.Ebx.CockpitBoxIBLEntityData;

		public CockpitBoxIBLEntity(FrostySdk.Ebx.CockpitBoxIBLEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

