using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipBlueprintSpawnerRelayEntityData))]
	public class StarshipBlueprintSpawnerRelayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipBlueprintSpawnerRelayEntityData>
	{
		public new FrostySdk.Ebx.StarshipBlueprintSpawnerRelayEntityData Data => data as FrostySdk.Ebx.StarshipBlueprintSpawnerRelayEntityData;
		public override string DisplayName => "StarshipBlueprintSpawnerRelay";

		public StarshipBlueprintSpawnerRelayEntity(FrostySdk.Ebx.StarshipBlueprintSpawnerRelayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

