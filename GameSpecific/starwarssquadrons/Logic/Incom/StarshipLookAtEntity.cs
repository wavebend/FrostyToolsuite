using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipLookAtEntityData))]
	public class StarshipLookAtEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipLookAtEntityData>
	{
		public new FrostySdk.Ebx.StarshipLookAtEntityData Data => data as FrostySdk.Ebx.StarshipLookAtEntityData;
		public override string DisplayName => "StarshipLookAt";

		public StarshipLookAtEntity(FrostySdk.Ebx.StarshipLookAtEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

