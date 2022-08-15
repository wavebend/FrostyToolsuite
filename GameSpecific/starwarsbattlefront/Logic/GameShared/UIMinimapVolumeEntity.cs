using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMinimapVolumeEntityData))]
	public class UIMinimapVolumeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMinimapVolumeEntityData>
	{
		public new FrostySdk.Ebx.UIMinimapVolumeEntityData Data => data as FrostySdk.Ebx.UIMinimapVolumeEntityData;
		public override string DisplayName => "UIMinimapVolume";

		public UIMinimapVolumeEntity(FrostySdk.Ebx.UIMinimapVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

