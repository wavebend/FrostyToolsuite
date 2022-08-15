using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitShakeEntityData))]
	public class CockpitShakeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CockpitShakeEntityData>
	{
		public new FrostySdk.Ebx.CockpitShakeEntityData Data => data as FrostySdk.Ebx.CockpitShakeEntityData;
		public override string DisplayName => "CockpitShake";

		public CockpitShakeEntity(FrostySdk.Ebx.CockpitShakeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

