using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomBulletEntityData))]
	public class IncomBulletEntity : BulletEntity, IEntityData<FrostySdk.Ebx.IncomBulletEntityData>
	{
		public new FrostySdk.Ebx.IncomBulletEntityData Data => data as FrostySdk.Ebx.IncomBulletEntityData;

		public IncomBulletEntity(FrostySdk.Ebx.IncomBulletEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

