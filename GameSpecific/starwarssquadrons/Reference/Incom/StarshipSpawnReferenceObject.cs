using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipSpawnReferenceObjectData))]
	public class StarshipSpawnReferenceObject : SpawnReferenceObject, IEntityData<FrostySdk.Ebx.StarshipSpawnReferenceObjectData>
	{
		public new FrostySdk.Ebx.StarshipSpawnReferenceObjectData Data => data as FrostySdk.Ebx.StarshipSpawnReferenceObjectData;

		public StarshipSpawnReferenceObject(FrostySdk.Ebx.StarshipSpawnReferenceObjectData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

