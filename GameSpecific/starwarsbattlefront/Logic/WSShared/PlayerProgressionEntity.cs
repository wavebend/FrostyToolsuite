using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerProgressionEntityData))]
	public class PlayerProgressionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerProgressionEntityData>
	{
		public new FrostySdk.Ebx.PlayerProgressionEntityData Data => data as FrostySdk.Ebx.PlayerProgressionEntityData;
		public override string DisplayName => "PlayerProgression";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PlayerProgressionEntity(FrostySdk.Ebx.PlayerProgressionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

