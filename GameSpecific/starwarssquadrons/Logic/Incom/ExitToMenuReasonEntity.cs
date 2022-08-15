using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ExitToMenuReasonEntityData))]
	public class ExitToMenuReasonEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ExitToMenuReasonEntityData>
	{
		public new FrostySdk.Ebx.ExitToMenuReasonEntityData Data => data as FrostySdk.Ebx.ExitToMenuReasonEntityData;
		public override string DisplayName => "ExitToMenuReason";

		public ExitToMenuReasonEntity(FrostySdk.Ebx.ExitToMenuReasonEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

