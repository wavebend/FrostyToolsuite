using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomActionFeedEntityData))]
	public class IncomActionFeedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomActionFeedEntityData>
	{
		public new FrostySdk.Ebx.IncomActionFeedEntityData Data => data as FrostySdk.Ebx.IncomActionFeedEntityData;
		public override string DisplayName => "IncomActionFeed";

		public IncomActionFeedEntity(FrostySdk.Ebx.IncomActionFeedEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

