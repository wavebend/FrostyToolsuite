using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameModePartySizeValidationEntityData))]
	public class GameModePartySizeValidationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GameModePartySizeValidationEntityData>
	{
		public new FrostySdk.Ebx.GameModePartySizeValidationEntityData Data => data as FrostySdk.Ebx.GameModePartySizeValidationEntityData;
		public override string DisplayName => "GameModePartySizeValidation";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public GameModePartySizeValidationEntity(FrostySdk.Ebx.GameModePartySizeValidationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

