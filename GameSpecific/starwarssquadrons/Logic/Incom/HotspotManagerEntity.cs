using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HotspotManagerEntityData))]
	public class HotspotManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HotspotManagerEntityData>
	{
		public new FrostySdk.Ebx.HotspotManagerEntityData Data => data as FrostySdk.Ebx.HotspotManagerEntityData;
		public override string DisplayName => "HotspotManager";

		public HotspotManagerEntity(FrostySdk.Ebx.HotspotManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

