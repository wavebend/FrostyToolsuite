using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipBlueprintLoaderEntityData))]
	public class StarshipBlueprintLoaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipBlueprintLoaderEntityData>
	{
		public new FrostySdk.Ebx.StarshipBlueprintLoaderEntityData Data => data as FrostySdk.Ebx.StarshipBlueprintLoaderEntityData;
		public override string DisplayName => "StarshipBlueprintLoader";

		public StarshipBlueprintLoaderEntity(FrostySdk.Ebx.StarshipBlueprintLoaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

