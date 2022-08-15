using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientPetitionEntityData))]
	public class ClientPetitionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientPetitionEntityData>
	{
		public new FrostySdk.Ebx.ClientPetitionEntityData Data => data as FrostySdk.Ebx.ClientPetitionEntityData;
		public override string DisplayName => "ClientPetition";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientPetitionEntity(FrostySdk.Ebx.ClientPetitionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

