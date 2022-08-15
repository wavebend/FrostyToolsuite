using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadarElementData))]
	public class RadarElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.RadarElementData>
	{
		public new FrostySdk.Ebx.RadarElementData Data => data as FrostySdk.Ebx.RadarElementData;
		public override string DisplayName => "RadarElement";

		public RadarElement(FrostySdk.Ebx.RadarElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

