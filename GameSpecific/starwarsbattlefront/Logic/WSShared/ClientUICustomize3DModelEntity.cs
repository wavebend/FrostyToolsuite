using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientUICustomize3DModelEntityData))]
	public class ClientUICustomize3DModelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientUICustomize3DModelEntityData>
	{
		public new FrostySdk.Ebx.ClientUICustomize3DModelEntityData Data => data as FrostySdk.Ebx.ClientUICustomize3DModelEntityData;
		public override string DisplayName => "ClientUICustomize3DModel";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ClientUICustomize3DModelEntity(FrostySdk.Ebx.ClientUICustomize3DModelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

