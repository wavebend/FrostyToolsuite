using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AttachmentEntityUpdaterData))]
	public class AttachmentEntityUpdater : LogicEntity, IEntityData<FrostySdk.Ebx.AttachmentEntityUpdaterData>
	{
		public new FrostySdk.Ebx.AttachmentEntityUpdaterData Data => data as FrostySdk.Ebx.AttachmentEntityUpdaterData;
		public override string DisplayName => "AttachmentEntityUpdater";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AttachmentEntityUpdater(FrostySdk.Ebx.AttachmentEntityUpdaterData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

