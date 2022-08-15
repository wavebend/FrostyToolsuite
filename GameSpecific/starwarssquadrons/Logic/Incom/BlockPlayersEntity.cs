using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BlockPlayersEntityData))]
	public class BlockPlayersEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BlockPlayersEntityData>
	{
		public new FrostySdk.Ebx.BlockPlayersEntityData Data => data as FrostySdk.Ebx.BlockPlayersEntityData;
		public override string DisplayName => "BlockPlayers";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public BlockPlayersEntity(FrostySdk.Ebx.BlockPlayersEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

