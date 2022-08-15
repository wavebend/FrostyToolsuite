using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomDecoyBuoyEntityData))]
	public class IncomDecoyBuoyEntity : IncomMissileEntity, IEntityData<FrostySdk.Ebx.IncomDecoyBuoyEntityData>
	{
		public new FrostySdk.Ebx.IncomDecoyBuoyEntityData Data => data as FrostySdk.Ebx.IncomDecoyBuoyEntityData;

		public IncomDecoyBuoyEntity(FrostySdk.Ebx.IncomDecoyBuoyEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

