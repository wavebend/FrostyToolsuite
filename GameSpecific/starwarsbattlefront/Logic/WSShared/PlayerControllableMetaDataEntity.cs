using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerControllableMetaDataEntityData))]
	public class PlayerControllableMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerControllableMetaDataEntityData>
	{
		public new FrostySdk.Ebx.PlayerControllableMetaDataEntityData Data => data as FrostySdk.Ebx.PlayerControllableMetaDataEntityData;
		public override string DisplayName => "PlayerControllableMetaData";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerControllableMetaDataEntity(FrostySdk.Ebx.PlayerControllableMetaDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

