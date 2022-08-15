using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitEmissiveLightsMathEntityData))]
	public class CockpitEmissiveLightsMathEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CockpitEmissiveLightsMathEntityData>
	{
		public new FrostySdk.Ebx.CockpitEmissiveLightsMathEntityData Data => data as FrostySdk.Ebx.CockpitEmissiveLightsMathEntityData;
		public override string DisplayName => "CockpitEmissiveLightsMath";

		public CockpitEmissiveLightsMathEntity(FrostySdk.Ebx.CockpitEmissiveLightsMathEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

