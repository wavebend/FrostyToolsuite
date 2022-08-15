using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretSpawnReferenceObjectData))]
	public class TurretSpawnReferenceObject : SpawnReferenceObject, IEntityData<FrostySdk.Ebx.TurretSpawnReferenceObjectData>
	{
		public new FrostySdk.Ebx.TurretSpawnReferenceObjectData Data => data as FrostySdk.Ebx.TurretSpawnReferenceObjectData;

		public TurretSpawnReferenceObject(FrostySdk.Ebx.TurretSpawnReferenceObjectData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

