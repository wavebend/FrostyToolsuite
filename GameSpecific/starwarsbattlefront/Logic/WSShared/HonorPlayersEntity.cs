using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HonorPlayersEntityData))]
	public class HonorPlayersEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HonorPlayersEntityData>
	{
		public new FrostySdk.Ebx.HonorPlayersEntityData Data => data as FrostySdk.Ebx.HonorPlayersEntityData;
		public override string DisplayName => "HonorPlayers";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HonorPlayersEntity(FrostySdk.Ebx.HonorPlayersEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

