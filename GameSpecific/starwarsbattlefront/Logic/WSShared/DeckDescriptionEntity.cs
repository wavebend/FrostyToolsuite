using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeckDescriptionEntityData))]
	public class DeckDescriptionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeckDescriptionEntityData>
	{
		public new FrostySdk.Ebx.DeckDescriptionEntityData Data => data as FrostySdk.Ebx.DeckDescriptionEntityData;
		public override string DisplayName => "DeckDescription";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DeckDescriptionEntity(FrostySdk.Ebx.DeckDescriptionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

