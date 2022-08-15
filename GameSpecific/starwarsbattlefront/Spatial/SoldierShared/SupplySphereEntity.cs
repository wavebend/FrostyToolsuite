using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SupplySphereEntityData))]
	public class SupplySphereEntity : ExplosionPackEntity, IEntityData<FrostySdk.Ebx.SupplySphereEntityData>
	{
		public new FrostySdk.Ebx.SupplySphereEntityData Data => data as FrostySdk.Ebx.SupplySphereEntityData;

		public SupplySphereEntity(FrostySdk.Ebx.SupplySphereEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

