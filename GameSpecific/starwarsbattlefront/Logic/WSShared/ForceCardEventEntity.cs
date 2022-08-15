using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardEventEntityData))]
	public class ForceCardEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardEventEntityData>
	{
		public new FrostySdk.Ebx.ForceCardEventEntityData Data => data as FrostySdk.Ebx.ForceCardEventEntityData;
		public override string DisplayName => "ForceCardEvent";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ForceCardEventEntity(FrostySdk.Ebx.ForceCardEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

