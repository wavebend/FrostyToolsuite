using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipDamageAreaEntityData))]
	public class StarshipDamageAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipDamageAreaEntityData>
	{
		public new FrostySdk.Ebx.StarshipDamageAreaEntityData Data => data as FrostySdk.Ebx.StarshipDamageAreaEntityData;
		public override string DisplayName => "StarshipDamageArea";

		public StarshipDamageAreaEntity(FrostySdk.Ebx.StarshipDamageAreaEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

