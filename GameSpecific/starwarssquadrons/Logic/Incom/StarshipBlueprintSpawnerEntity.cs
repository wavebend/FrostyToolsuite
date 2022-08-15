using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipBlueprintSpawnerEntityData))]
	public class StarshipBlueprintSpawnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipBlueprintSpawnerEntityData>
	{
		public new FrostySdk.Ebx.StarshipBlueprintSpawnerEntityData Data => data as FrostySdk.Ebx.StarshipBlueprintSpawnerEntityData;
		public override string DisplayName => "StarshipBlueprintSpawner";

		public StarshipBlueprintSpawnerEntity(FrostySdk.Ebx.StarshipBlueprintSpawnerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

