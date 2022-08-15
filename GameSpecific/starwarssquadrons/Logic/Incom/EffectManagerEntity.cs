using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EffectManagerEntityData))]
	public class EffectManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EffectManagerEntityData>
	{
		public new FrostySdk.Ebx.EffectManagerEntityData Data => data as FrostySdk.Ebx.EffectManagerEntityData;
		public override string DisplayName => "EffectManager";

		public EffectManagerEntity(FrostySdk.Ebx.EffectManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

