using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RailRideSpeedOverriderEntityData))]
	public class RailRideSpeedOverriderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RailRideSpeedOverriderEntityData>
	{
		public new FrostySdk.Ebx.RailRideSpeedOverriderEntityData Data => data as FrostySdk.Ebx.RailRideSpeedOverriderEntityData;
		public override string DisplayName => "RailRideSpeedOverrider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public RailRideSpeedOverriderEntity(FrostySdk.Ebx.RailRideSpeedOverriderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

