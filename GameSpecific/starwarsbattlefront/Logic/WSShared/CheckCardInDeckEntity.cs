using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CheckCardInDeckEntityData))]
	public class CheckCardInDeckEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CheckCardInDeckEntityData>
	{
		public new FrostySdk.Ebx.CheckCardInDeckEntityData Data => data as FrostySdk.Ebx.CheckCardInDeckEntityData;
		public override string DisplayName => "CheckCardInDeck";

		public CheckCardInDeckEntity(FrostySdk.Ebx.CheckCardInDeckEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

