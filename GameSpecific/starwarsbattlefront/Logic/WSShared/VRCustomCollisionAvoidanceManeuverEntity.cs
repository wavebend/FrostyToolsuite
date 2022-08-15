using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRCustomCollisionAvoidanceManeuverEntityData))]
	public class VRCustomCollisionAvoidanceManeuverEntity : DogFightManeuverEntityBase, IEntityData<FrostySdk.Ebx.VRCustomCollisionAvoidanceManeuverEntityData>
	{
		public new FrostySdk.Ebx.VRCustomCollisionAvoidanceManeuverEntityData Data => data as FrostySdk.Ebx.VRCustomCollisionAvoidanceManeuverEntityData;
		public override string DisplayName => "VRCustomCollisionAvoidanceManeuver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRCustomCollisionAvoidanceManeuverEntity(FrostySdk.Ebx.VRCustomCollisionAvoidanceManeuverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

