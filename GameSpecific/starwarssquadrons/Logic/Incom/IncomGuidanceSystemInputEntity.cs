using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomGuidanceSystemInputEntityData))]
	public class IncomGuidanceSystemInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomGuidanceSystemInputEntityData>
	{
		public new FrostySdk.Ebx.IncomGuidanceSystemInputEntityData Data => data as FrostySdk.Ebx.IncomGuidanceSystemInputEntityData;
		public override string DisplayName => "IncomGuidanceSystemInput";

		public IncomGuidanceSystemInputEntity(FrostySdk.Ebx.IncomGuidanceSystemInputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

