using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientEventMetaStatEntityData))]
	public class ClientEventMetaStatEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientEventMetaStatEntityData>
	{
		public new FrostySdk.Ebx.ClientEventMetaStatEntityData Data => data as FrostySdk.Ebx.ClientEventMetaStatEntityData;
		public override string DisplayName => "ClientEventMetaStat";

		public ClientEventMetaStatEntity(FrostySdk.Ebx.ClientEventMetaStatEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

