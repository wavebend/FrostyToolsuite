using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompareRadarTargetTagsData))]
	public class CompareRadarTargetTags : LogicEntity, IEntityData<FrostySdk.Ebx.CompareRadarTargetTagsData>
	{
		public new FrostySdk.Ebx.CompareRadarTargetTagsData Data => data as FrostySdk.Ebx.CompareRadarTargetTagsData;
		public override string DisplayName => "CompareRadarTargetTags";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CompareRadarTargetTags(FrostySdk.Ebx.CompareRadarTargetTagsData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

