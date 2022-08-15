using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipKitMetaDataEntityData))]
	public class StarshipKitMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipKitMetaDataEntityData>
	{
		public new FrostySdk.Ebx.StarshipKitMetaDataEntityData Data => data as FrostySdk.Ebx.StarshipKitMetaDataEntityData;
		public override string DisplayName => "StarshipKitMetaData";

		public StarshipKitMetaDataEntity(FrostySdk.Ebx.StarshipKitMetaDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

