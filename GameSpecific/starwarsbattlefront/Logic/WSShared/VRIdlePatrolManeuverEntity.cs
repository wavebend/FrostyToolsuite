using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRIdlePatrolManeuverEntityData))]
	public class VRIdlePatrolManeuverEntity : DogFightManeuverEntityBase, IEntityData<FrostySdk.Ebx.VRIdlePatrolManeuverEntityData>
	{
		public new FrostySdk.Ebx.VRIdlePatrolManeuverEntityData Data => data as FrostySdk.Ebx.VRIdlePatrolManeuverEntityData;
		public override string DisplayName => "VRIdlePatrolManeuver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRIdlePatrolManeuverEntity(FrostySdk.Ebx.VRIdlePatrolManeuverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

