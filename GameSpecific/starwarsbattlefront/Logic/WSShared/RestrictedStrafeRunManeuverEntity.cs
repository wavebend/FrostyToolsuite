using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RestrictedStrafeRunManeuverEntityData))]
	public class RestrictedStrafeRunManeuverEntity : DogFightManeuverEntityBase, IEntityData<FrostySdk.Ebx.RestrictedStrafeRunManeuverEntityData>
	{
		public new FrostySdk.Ebx.RestrictedStrafeRunManeuverEntityData Data => data as FrostySdk.Ebx.RestrictedStrafeRunManeuverEntityData;
		public override string DisplayName => "RestrictedStrafeRunManeuver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public RestrictedStrafeRunManeuverEntity(FrostySdk.Ebx.RestrictedStrafeRunManeuverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

