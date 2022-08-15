using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameModeSuggestionEntityData))]
	public class GameModeSuggestionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GameModeSuggestionEntityData>
	{
		public new FrostySdk.Ebx.GameModeSuggestionEntityData Data => data as FrostySdk.Ebx.GameModeSuggestionEntityData;
		public override string DisplayName => "GameModeSuggestion";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public GameModeSuggestionEntity(FrostySdk.Ebx.GameModeSuggestionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

