using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitLightEventReceiveEntityData))]
	public class CockpitLightEventReceiveEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CockpitLightEventReceiveEntityData>
	{
		public new FrostySdk.Ebx.CockpitLightEventReceiveEntityData Data => data as FrostySdk.Ebx.CockpitLightEventReceiveEntityData;
		public override string DisplayName => "CockpitLightEventReceive";

		public CockpitLightEventReceiveEntity(FrostySdk.Ebx.CockpitLightEventReceiveEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

