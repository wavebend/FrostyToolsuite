using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipMaxSpeedOverrideEntityData))]
	public class StarshipMaxSpeedOverrideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipMaxSpeedOverrideEntityData>
	{
		public new FrostySdk.Ebx.StarshipMaxSpeedOverrideEntityData Data => data as FrostySdk.Ebx.StarshipMaxSpeedOverrideEntityData;
		public override string DisplayName => "StarshipMaxSpeedOverride";

		public StarshipMaxSpeedOverrideEntity(FrostySdk.Ebx.StarshipMaxSpeedOverrideEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

