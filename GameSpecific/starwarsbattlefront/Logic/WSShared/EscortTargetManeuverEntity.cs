using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EscortTargetManeuverEntityData))]
	public class EscortTargetManeuverEntity : DogFightManeuverEntityBase, IEntityData<FrostySdk.Ebx.EscortTargetManeuverEntityData>
	{
		public new FrostySdk.Ebx.EscortTargetManeuverEntityData Data => data as FrostySdk.Ebx.EscortTargetManeuverEntityData;
		public override string DisplayName => "EscortTargetManeuver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public EscortTargetManeuverEntity(FrostySdk.Ebx.EscortTargetManeuverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

