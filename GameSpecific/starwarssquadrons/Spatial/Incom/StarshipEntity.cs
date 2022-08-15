using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipEntityData))]
	public class StarshipEntity : ControllableEntity, IEntityData<FrostySdk.Ebx.StarshipEntityData>
	{
		public new FrostySdk.Ebx.StarshipEntityData Data => data as FrostySdk.Ebx.StarshipEntityData;

		public StarshipEntity(FrostySdk.Ebx.StarshipEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

