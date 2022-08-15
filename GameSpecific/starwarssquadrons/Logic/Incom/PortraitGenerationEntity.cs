using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PortraitGenerationEntityData))]
	public class PortraitGenerationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PortraitGenerationEntityData>
	{
		public new FrostySdk.Ebx.PortraitGenerationEntityData Data => data as FrostySdk.Ebx.PortraitGenerationEntityData;
		public override string DisplayName => "PortraitGeneration";

		public PortraitGenerationEntity(FrostySdk.Ebx.PortraitGenerationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

