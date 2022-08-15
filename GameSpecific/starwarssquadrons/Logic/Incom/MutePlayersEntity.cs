using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MutePlayersEntityData))]
	public class MutePlayersEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MutePlayersEntityData>
	{
		public new FrostySdk.Ebx.MutePlayersEntityData Data => data as FrostySdk.Ebx.MutePlayersEntityData;
		public override string DisplayName => "MutePlayers";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public MutePlayersEntity(FrostySdk.Ebx.MutePlayersEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

