using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AttachmentEntityData))]
	public class AttachmentEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AttachmentEntityData>
	{
		public new FrostySdk.Ebx.AttachmentEntityData Data => data as FrostySdk.Ebx.AttachmentEntityData;
		public override string DisplayName => "Attachment";

		public AttachmentEntity(FrostySdk.Ebx.AttachmentEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

