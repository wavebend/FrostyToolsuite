using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipAlternateSpawnEntityData))]
	public class StarshipAlternateSpawnEntity : AlternateSpawnEntity, IEntityData<FrostySdk.Ebx.StarshipAlternateSpawnEntityData>
	{
		public new FrostySdk.Ebx.StarshipAlternateSpawnEntityData Data => data as FrostySdk.Ebx.StarshipAlternateSpawnEntityData;

		public StarshipAlternateSpawnEntity(FrostySdk.Ebx.StarshipAlternateSpawnEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

