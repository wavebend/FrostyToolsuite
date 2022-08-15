using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubSelfEntityData))]
	public class HubSelfEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubSelfEntityData>
	{
		public new FrostySdk.Ebx.HubSelfEntityData Data => data as FrostySdk.Ebx.HubSelfEntityData;
		public override string DisplayName => "HubSelf";

		public HubSelfEntity(FrostySdk.Ebx.HubSelfEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

