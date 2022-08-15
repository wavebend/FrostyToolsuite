using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ServerUICustomize3DModelEntityData))]
	public class ServerUICustomize3DModelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ServerUICustomize3DModelEntityData>
	{
		public new FrostySdk.Ebx.ServerUICustomize3DModelEntityData Data => data as FrostySdk.Ebx.ServerUICustomize3DModelEntityData;
		public override string DisplayName => "ServerUICustomize3DModel";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ServerUICustomize3DModelEntity(FrostySdk.Ebx.ServerUICustomize3DModelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

