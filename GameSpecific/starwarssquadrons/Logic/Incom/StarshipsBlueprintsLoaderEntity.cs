using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipsBlueprintsLoaderEntityData))]
	public class StarshipsBlueprintsLoaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipsBlueprintsLoaderEntityData>
	{
		public new FrostySdk.Ebx.StarshipsBlueprintsLoaderEntityData Data => data as FrostySdk.Ebx.StarshipsBlueprintsLoaderEntityData;
		public override string DisplayName => "StarshipsBlueprintsLoader";

		public StarshipsBlueprintsLoaderEntity(FrostySdk.Ebx.StarshipsBlueprintsLoaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

