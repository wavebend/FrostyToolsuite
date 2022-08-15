using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NPSVRSubmissionEntityData))]
	public class NPSVRSubmissionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.NPSVRSubmissionEntityData>
	{
		public new FrostySdk.Ebx.NPSVRSubmissionEntityData Data => data as FrostySdk.Ebx.NPSVRSubmissionEntityData;
		public override string DisplayName => "NPSVRSubmission";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public NPSVRSubmissionEntity(FrostySdk.Ebx.NPSVRSubmissionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

