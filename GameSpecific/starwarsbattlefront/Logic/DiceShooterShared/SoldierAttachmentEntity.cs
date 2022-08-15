using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierAttachmentEntityData))]
	public class SoldierAttachmentEntity : AttachmentEntity, IEntityData<FrostySdk.Ebx.SoldierAttachmentEntityData>
	{
		public new FrostySdk.Ebx.SoldierAttachmentEntityData Data => data as FrostySdk.Ebx.SoldierAttachmentEntityData;
		public override string DisplayName => "SoldierAttachment";

		public SoldierAttachmentEntity(FrostySdk.Ebx.SoldierAttachmentEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

