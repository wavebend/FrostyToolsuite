using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomExplosionEntityData))]
	public class IncomExplosionEntity : ExplosionEntity, IEntityData<FrostySdk.Ebx.IncomExplosionEntityData>
	{
		public new FrostySdk.Ebx.IncomExplosionEntityData Data => data as FrostySdk.Ebx.IncomExplosionEntityData;

		public IncomExplosionEntity(FrostySdk.Ebx.IncomExplosionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

