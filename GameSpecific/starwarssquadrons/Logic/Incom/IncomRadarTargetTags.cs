using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomRadarTargetTagsData))]
	public class IncomRadarTargetTags : LogicEntity, IEntityData<FrostySdk.Ebx.IncomRadarTargetTagsData>
	{
		public new FrostySdk.Ebx.IncomRadarTargetTagsData Data => data as FrostySdk.Ebx.IncomRadarTargetTagsData;
		public override string DisplayName => "IncomRadarTargetTags";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomRadarTargetTags(FrostySdk.Ebx.IncomRadarTargetTagsData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

