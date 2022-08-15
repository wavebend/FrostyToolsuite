using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientFrontendStatReaderEntityData))]
	public class ClientFrontendStatReaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientFrontendStatReaderEntityData>
	{
		public new FrostySdk.Ebx.ClientFrontendStatReaderEntityData Data => data as FrostySdk.Ebx.ClientFrontendStatReaderEntityData;
		public override string DisplayName => "ClientFrontendStatReader";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientFrontendStatReaderEntity(FrostySdk.Ebx.ClientFrontendStatReaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

