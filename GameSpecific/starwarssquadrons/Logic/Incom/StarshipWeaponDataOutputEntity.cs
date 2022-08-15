using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipWeaponDataOutputEntityData))]
	public class StarshipWeaponDataOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipWeaponDataOutputEntityData>
	{
		public new FrostySdk.Ebx.StarshipWeaponDataOutputEntityData Data => data as FrostySdk.Ebx.StarshipWeaponDataOutputEntityData;
		public override string DisplayName => "StarshipWeaponDataOutput";

		public StarshipWeaponDataOutputEntity(FrostySdk.Ebx.StarshipWeaponDataOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

