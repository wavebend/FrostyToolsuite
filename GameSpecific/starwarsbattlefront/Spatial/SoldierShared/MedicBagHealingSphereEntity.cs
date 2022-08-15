using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MedicBagHealingSphereEntityData))]
	public class MedicBagHealingSphereEntity : ExplosionPackEntity, IEntityData<FrostySdk.Ebx.MedicBagHealingSphereEntityData>
	{
		public new FrostySdk.Ebx.MedicBagHealingSphereEntityData Data => data as FrostySdk.Ebx.MedicBagHealingSphereEntityData;

		public MedicBagHealingSphereEntity(FrostySdk.Ebx.MedicBagHealingSphereEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

