using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientStarsInfoEntityData))]
	public class ClientStarsInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientStarsInfoEntityData>
	{
		public new FrostySdk.Ebx.ClientStarsInfoEntityData Data => data as FrostySdk.Ebx.ClientStarsInfoEntityData;
		public override string DisplayName => "ClientStarsInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientStarsInfoEntity(FrostySdk.Ebx.ClientStarsInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

