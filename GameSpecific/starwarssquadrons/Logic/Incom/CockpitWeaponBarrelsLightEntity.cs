using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitWeaponBarrelsLightEntityData))]
	public class CockpitWeaponBarrelsLightEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CockpitWeaponBarrelsLightEntityData>
	{
		public new FrostySdk.Ebx.CockpitWeaponBarrelsLightEntityData Data => data as FrostySdk.Ebx.CockpitWeaponBarrelsLightEntityData;
		public override string DisplayName => "CockpitWeaponBarrelsLight";

		public CockpitWeaponBarrelsLightEntity(FrostySdk.Ebx.CockpitWeaponBarrelsLightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

