using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomMissileEntityData))]
	public class IncomMissileEntity : MissileEntity, IEntityData<FrostySdk.Ebx.IncomMissileEntityData>
	{
		public new FrostySdk.Ebx.IncomMissileEntityData Data => data as FrostySdk.Ebx.IncomMissileEntityData;

		public IncomMissileEntity(FrostySdk.Ebx.IncomMissileEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

