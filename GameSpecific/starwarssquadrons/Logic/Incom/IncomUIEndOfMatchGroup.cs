using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIEndOfMatchGroupData))]
	public class IncomUIEndOfMatchGroup : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIEndOfMatchGroupData>
	{
		public new FrostySdk.Ebx.IncomUIEndOfMatchGroupData Data => data as FrostySdk.Ebx.IncomUIEndOfMatchGroupData;
		public override string DisplayName => "IncomUIEndOfMatchGroup";

		public IncomUIEndOfMatchGroup(FrostySdk.Ebx.IncomUIEndOfMatchGroupData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

