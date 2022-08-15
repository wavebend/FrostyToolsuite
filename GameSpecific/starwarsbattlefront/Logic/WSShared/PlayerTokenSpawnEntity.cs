using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerTokenSpawnEntityData))]
	public class PlayerTokenSpawnEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerTokenSpawnEntityData>
	{
		public new FrostySdk.Ebx.PlayerTokenSpawnEntityData Data => data as FrostySdk.Ebx.PlayerTokenSpawnEntityData;
		public override string DisplayName => "PlayerTokenSpawn";

		public PlayerTokenSpawnEntity(FrostySdk.Ebx.PlayerTokenSpawnEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

