using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerCustomizationConsolidationEntityData))]
	public class PlayerCustomizationConsolidationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerCustomizationConsolidationEntityData>
	{
		public new FrostySdk.Ebx.PlayerCustomizationConsolidationEntityData Data => data as FrostySdk.Ebx.PlayerCustomizationConsolidationEntityData;
		public override string DisplayName => "PlayerCustomizationConsolidation";

		public PlayerCustomizationConsolidationEntity(FrostySdk.Ebx.PlayerCustomizationConsolidationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

