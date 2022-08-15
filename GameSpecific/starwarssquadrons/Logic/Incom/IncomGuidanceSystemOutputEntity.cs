using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomGuidanceSystemOutputEntityData))]
	public class IncomGuidanceSystemOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomGuidanceSystemOutputEntityData>
	{
		public new FrostySdk.Ebx.IncomGuidanceSystemOutputEntityData Data => data as FrostySdk.Ebx.IncomGuidanceSystemOutputEntityData;
		public override string DisplayName => "IncomGuidanceSystemOutput";

		public IncomGuidanceSystemOutputEntity(FrostySdk.Ebx.IncomGuidanceSystemOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

