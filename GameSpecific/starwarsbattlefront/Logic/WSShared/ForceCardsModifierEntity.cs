using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardsModifierEntityData))]
	public class ForceCardsModifierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardsModifierEntityData>
	{
		public new FrostySdk.Ebx.ForceCardsModifierEntityData Data => data as FrostySdk.Ebx.ForceCardsModifierEntityData;
		public override string DisplayName => "ForceCardsModifier";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ForceCardsModifierEntity(FrostySdk.Ebx.ForceCardsModifierEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

