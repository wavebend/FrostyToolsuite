using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitLightEventDispatchEntityData))]
	public class CockpitLightEventDispatchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CockpitLightEventDispatchEntityData>
	{
		public new FrostySdk.Ebx.CockpitLightEventDispatchEntityData Data => data as FrostySdk.Ebx.CockpitLightEventDispatchEntityData;
		public override string DisplayName => "CockpitLightEventDispatch";

		public CockpitLightEventDispatchEntity(FrostySdk.Ebx.CockpitLightEventDispatchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

