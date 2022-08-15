using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HotspotEntityData))]
	public class HotspotEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HotspotEntityData>
	{
		public new FrostySdk.Ebx.HotspotEntityData Data => data as FrostySdk.Ebx.HotspotEntityData;
		public override string DisplayName => "Hotspot";

		public HotspotEntity(FrostySdk.Ebx.HotspotEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

