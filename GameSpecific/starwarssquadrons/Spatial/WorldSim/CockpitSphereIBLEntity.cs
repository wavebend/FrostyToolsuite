using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitSphereIBLEntityData))]
	public class CockpitSphereIBLEntity : PbrReflectionVolumeEntity, IEntityData<FrostySdk.Ebx.CockpitSphereIBLEntityData>
	{
		public new FrostySdk.Ebx.CockpitSphereIBLEntityData Data => data as FrostySdk.Ebx.CockpitSphereIBLEntityData;

		public CockpitSphereIBLEntity(FrostySdk.Ebx.CockpitSphereIBLEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

