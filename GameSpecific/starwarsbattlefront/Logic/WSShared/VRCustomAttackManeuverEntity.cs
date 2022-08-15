using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRCustomAttackManeuverEntityData))]
	public class VRCustomAttackManeuverEntity : DogFightManeuverEntityBase, IEntityData<FrostySdk.Ebx.VRCustomAttackManeuverEntityData>
	{
		public new FrostySdk.Ebx.VRCustomAttackManeuverEntityData Data => data as FrostySdk.Ebx.VRCustomAttackManeuverEntityData;
		public override string DisplayName => "VRCustomAttackManeuver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRCustomAttackManeuverEntity(FrostySdk.Ebx.VRCustomAttackManeuverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

