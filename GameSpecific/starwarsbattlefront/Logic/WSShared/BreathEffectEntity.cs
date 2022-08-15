using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BreathEffectEntityData))]
	public class BreathEffectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BreathEffectEntityData>
	{
		public new FrostySdk.Ebx.BreathEffectEntityData Data => data as FrostySdk.Ebx.BreathEffectEntityData;
		public override string DisplayName => "BreathEffect";

		public BreathEffectEntity(FrostySdk.Ebx.BreathEffectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

