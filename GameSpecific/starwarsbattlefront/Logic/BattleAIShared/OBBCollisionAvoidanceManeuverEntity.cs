using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OBBCollisionAvoidanceManeuverEntityData))]
	public class OBBCollisionAvoidanceManeuverEntity : DogFightManeuverEntityBase, IEntityData<FrostySdk.Ebx.OBBCollisionAvoidanceManeuverEntityData>
	{
		public new FrostySdk.Ebx.OBBCollisionAvoidanceManeuverEntityData Data => data as FrostySdk.Ebx.OBBCollisionAvoidanceManeuverEntityData;
		public override string DisplayName => "OBBCollisionAvoidanceManeuver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public OBBCollisionAvoidanceManeuverEntity(FrostySdk.Ebx.OBBCollisionAvoidanceManeuverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

