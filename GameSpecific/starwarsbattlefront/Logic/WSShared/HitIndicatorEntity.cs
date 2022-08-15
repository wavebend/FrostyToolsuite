using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HitIndicatorEntityData))]
	public class HitIndicatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HitIndicatorEntityData>
	{
		public new FrostySdk.Ebx.HitIndicatorEntityData Data => data as FrostySdk.Ebx.HitIndicatorEntityData;
		public override string DisplayName => "HitIndicator";

		public HitIndicatorEntity(FrostySdk.Ebx.HitIndicatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

