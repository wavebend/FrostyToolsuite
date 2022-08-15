using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretEntityData))]
	public class TurretEntity : ControllableEntity, IEntityData<FrostySdk.Ebx.TurretEntityData>
	{
		public new FrostySdk.Ebx.TurretEntityData Data => data as FrostySdk.Ebx.TurretEntityData;

		public TurretEntity(FrostySdk.Ebx.TurretEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

