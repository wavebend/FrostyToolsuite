using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipKitIdEntityData))]
	public class StarshipKitIdEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipKitIdEntityData>
	{
		public new FrostySdk.Ebx.StarshipKitIdEntityData Data => data as FrostySdk.Ebx.StarshipKitIdEntityData;
		public override string DisplayName => "StarshipKitId";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public StarshipKitIdEntity(FrostySdk.Ebx.StarshipKitIdEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

