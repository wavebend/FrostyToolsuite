using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientDFSimSpawnerEntityData))]
	public class ClientDFSimSpawnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientDFSimSpawnerEntityData>
	{
		public new FrostySdk.Ebx.ClientDFSimSpawnerEntityData Data => data as FrostySdk.Ebx.ClientDFSimSpawnerEntityData;
		public override string DisplayName => "ClientDFSimSpawner";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientDFSimSpawnerEntity(FrostySdk.Ebx.ClientDFSimSpawnerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

