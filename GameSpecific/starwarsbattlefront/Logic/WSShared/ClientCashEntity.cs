using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientCashEntityData))]
	public class ClientCashEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientCashEntityData>
	{
		public new FrostySdk.Ebx.ClientCashEntityData Data => data as FrostySdk.Ebx.ClientCashEntityData;
		public override string DisplayName => "ClientCash";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientCashEntity(FrostySdk.Ebx.ClientCashEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

