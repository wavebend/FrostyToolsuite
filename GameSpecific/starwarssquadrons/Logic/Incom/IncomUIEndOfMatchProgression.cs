using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIEndOfMatchProgressionData))]
	public class IncomUIEndOfMatchProgression : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIEndOfMatchProgressionData>
	{
		public new FrostySdk.Ebx.IncomUIEndOfMatchProgressionData Data => data as FrostySdk.Ebx.IncomUIEndOfMatchProgressionData;
		public override string DisplayName => "IncomUIEndOfMatchProgression";

		public IncomUIEndOfMatchProgression(FrostySdk.Ebx.IncomUIEndOfMatchProgressionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

