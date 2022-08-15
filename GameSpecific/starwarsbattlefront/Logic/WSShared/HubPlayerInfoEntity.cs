using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubPlayerInfoEntityData))]
	public class HubPlayerInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubPlayerInfoEntityData>
	{
		public new FrostySdk.Ebx.HubPlayerInfoEntityData Data => data as FrostySdk.Ebx.HubPlayerInfoEntityData;
		public override string DisplayName => "HubPlayerInfo";

		public HubPlayerInfoEntity(FrostySdk.Ebx.HubPlayerInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

